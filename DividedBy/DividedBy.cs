using System;

class DividedBy
{
    static void Main()
    {
        int DividedBy = int.Parse(Console.ReadLine());

        if (DividedBy % 5 == 0 && DividedBy % 7 == 0)
        {
            Console.WriteLine("true {0}",DividedBy);
        }
        else
        {
            Console.WriteLine("false {0}", DividedBy);
        }
    }
}
