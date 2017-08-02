using System;

class PrimeCheck
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double squareN = Math.Sqrt(N);
        string result = "true";

        if (N > 0 && N != 1)
        {
            for (int i = 2; i < N; i++)
            {

                if ((N % i) == 0)
                {
                    result = "false";
                }
            }
        }
        else
        {
            result = "false";
        }
        Console.WriteLine(result);
    }
}