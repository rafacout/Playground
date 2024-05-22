namespace Playground.Console;

public static class Numbers
{
    public static void Execute()
    {
        System.Console.WriteLine("Hello Numbers");
        System.Console.WriteLine("");
        
        uint naturalNumber = 23;
        int integer = -23;
        long longNumber = 23;
        ulong longNaturalNumber = 23;
        float realNumber = 23.5F;
        double realNumber2 = 23.5D;
        decimal realNumber3 = 23_000_000.50M;

        int binary = 0b_0001_1110;
        int hex = 0x_1E00_8480;

        System.Console.WriteLine(binary);
    }
}