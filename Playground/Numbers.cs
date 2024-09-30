namespace Playground;

public static class Numbers
{
    public static void Execute()
    {
        Console.WriteLine("Hello Numbers");
        Console.WriteLine("");

        //Postfix
        //L = long
        //UL = ulong
        //M = decimal
        //D = double
        //F = float

        uint naturalNumber = 12;
        var integer = -23;
        long longNumber = 23;
        ulong longNaturalNumber = 23;
        var realNumber = 23.5F;
        var realNumber2 = 23.5D;
        var realNumber3 = 23_000_000.50M;

        var binary = 0b_0001_1110;
        var hex = 0x_1E00_8480;

        //by default this is a double variable
        var x = 50.5;

        Console.WriteLine(binary);
    }
}