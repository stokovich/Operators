using System;

class ThirdDigit
{
    static void Main()
    {
        int Nstring = int.Parse(Console.ReadLine());
        int ThirdDigit = (Nstring / 100) % 10;

        if (ThirdDigit == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}",ThirdDigit);
        }
    }
}