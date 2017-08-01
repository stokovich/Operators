using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        
        double Area = width * height;
        double Perimeter = (2 * width) + (2 * height);

        Console.WriteLine("{0:0.00} {1:0.00}",Area,Perimeter);
    }
}
