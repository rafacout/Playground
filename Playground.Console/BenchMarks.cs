using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.Emit;

namespace Playground.Console;

// | Method   | Mean       | Error    | StdDev   |
// |--------- |-----------:|---------:|---------:|
// | ForArray |   556.4 ns | 10.83 ns | 11.59 ns |
// | ForList  | 1,159.9 ns | 10.86 ns |  9.07 ns |

public class BenchMarks
{
    public int[] array;
    public List<int> list;
    
    public void Execute()
    {
        var config = ManualConfig.Create(DefaultConfig.Instance)
            .WithOption(ConfigOptions.DisableOptimizationsValidator, true)
            .AddJob(Job.Default.WithToolchain(InProcessEmitToolchain.Instance));
        BenchmarkRunner.Run<BenchMarks>(config);
    }

    [GlobalSetup]
    public void Setup()
    {
        array = new int[1000];
        list = new List<int>();
        
        var random = new Random();
        for (int i = 0; i < 1000; i++)
        {
            var item = random.Next(0, 1000);
            array[i] = item;
            list.Add(item);
        }
    }
    
    [Benchmark]
    public void ForArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] *= 2;
        }
    }
    
    [Benchmark]
    public void ForList()
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] *= 2;
        }
    }
}