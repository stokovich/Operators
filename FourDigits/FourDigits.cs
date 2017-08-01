using System;

class FourDigits
{
    static void Main()
    {
        string FourDigits = Console.ReadLine();
        int a = int.Parse(FourDigits.Substring(0, 1));
        int b = int.Parse(FourDigits.Substring(1, 1));
        int c = int.Parse(FourDigits.Substring(2, 1));
        int d = int.Parse(FourDigits.Substring(3, 1));

        int Sum = a + b + c + d;

        Console.WriteLine(Sum);
        Console.WriteLine("{3}{2}{1}{0}", a, b, c, d);
        Console.WriteLine("{3}{0}{1}{2}", a, b, c, d);
        Console.WriteLine("{0}{2}{1}{3}", a, b, c, d);
    }

}
