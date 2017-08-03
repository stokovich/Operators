using System;

class CicleRectangleIO
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        string rescircle;
        string resrectangle;

        if ( ( Math.Pow(x - 1,2) + Math.Pow(y - 1,2) ) <= Math.Pow(1.5,2))
        {
            rescircle = "inside circle";
        }
        else
        {
            rescircle = "outside circle";
        }

        if ( x >= -1 && x <= 5 && y >= -1 && y <= 1)
        {
            resrectangle = "inside rectangle";
        }
        else
        {
            resrectangle = "outside rectangle";
        }
        Console.WriteLine("{0} {1}",rescircle,resrectangle);
    }
}
