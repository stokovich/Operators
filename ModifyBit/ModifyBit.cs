using System;

class ModifyBit
{
    static void Main()
    {
        ulong N = ulong.Parse(Console.ReadLine());
        byte P = byte.Parse(Console.ReadLine());
        byte v = byte.Parse(Console.ReadLine());
        ulong Mask = (ulong)1 << P;
        ulong Maskinverted = ~Mask;
        ulong NandMask;

        if (v == 1)
        {
            NandMask = N | Mask;
        }
        else
        {
            NandMask = N & Maskinverted;
        }


        // Console.WriteLine(Convert.ToString((long)N, 2).PadLeft(16, '0'));
        // Console.WriteLine(Convert.ToString((long)Mask, 2).PadLeft(16, '0'));
        // Console.WriteLine(Convert.ToString((long)Maskinverted, 2).PadLeft(16, '0'));
        // Console.WriteLine(Convert.ToString((long)NandMask, 2).PadLeft(16, '0'));

        Console.WriteLine(NandMask);
    }
}
