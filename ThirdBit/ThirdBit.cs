using System;

class ThirdBit
{
    static void Main()
    {
        int Position = 3;
        int Mask = 1 << Position;
        int Number = int.Parse(Console.ReadLine());
        int NumberAndMask = Number & Mask;
        int Result = NumberAndMask >> Position;

        Console.WriteLine(Result);
    }
}
