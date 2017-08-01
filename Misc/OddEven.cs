using System;
class OddEven
{
    static void Main()
    {
        //int oddoreven = int.Parse(Console.ReadLine());
        //if (oddoreven % 2 == 0)
        //{
        //    Console.WriteLine("even {0}",oddoreven);
        //}
        //else
        //{
        //    Console.WriteLine("odd {0}", oddoreven);
        //}

        float weight = float.Parse(Console.ReadLine());
        float weightonmoon = weight * 17 / 100;

        Console.WriteLine(weightonmoon.ToString("n3"));
    }
}
