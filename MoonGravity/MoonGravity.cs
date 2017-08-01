using System;

class MoonGravity
{
    static void Main()
    {
        float weight = float.Parse(Console.ReadLine());
        float weightonmoon = weight * 17 / 100;

        Console.WriteLine(weightonmoon.ToString("n3"));
    }
}
