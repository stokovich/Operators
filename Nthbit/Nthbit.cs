using System;

class Nthbit
{
    static void Main()
    {
        ulong P = ulong.Parse(Console.ReadLine());
        byte N = byte.Parse(Console.ReadLine());

        int Mask = 1 << N;
        ulong PandMask = P & (ulong)Mask;
        ulong Result = PandMask >> N;

        Console.WriteLine(Result);
    }
}
