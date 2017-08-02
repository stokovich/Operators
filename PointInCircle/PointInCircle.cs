using System;

class PointInCircle
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());

        decimal c = (decimal)Math.Sqrt((double)(a * a + b * b));

        if (c <= 2)
        {
            Console.WriteLine("yes {0:0.00}",c);
        }
        else
        {
            Console.WriteLine("no {0:0.00}", c);
        }
    }
}
