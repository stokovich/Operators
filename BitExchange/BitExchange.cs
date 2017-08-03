using System;

class BitExchange
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        byte p1 = byte.Parse(Console.ReadLine());
        byte p2 = byte.Parse(Console.ReadLine());
        byte step = byte.Parse(Console.ReadLine());
        uint maskandp1;
        uint maskandp2;
        uint nmod = n;
        uint maskp1;
        uint maskp2;
        uint p1start;
        uint p2start;

        for (byte i = 0; i < step; i++)
        {
            maskp1 = (uint)1 << (p1 + i);
            maskp2 = (uint)1 << (p2 + i);

            maskandp1 = n & maskp1;
            maskandp2 = n & maskp2;

            p1start = maskandp1 >> (p1 + i);
            p2start = maskandp2 >> (p2 + i);
            
            if (p1start == 1)
            {
                nmod = nmod | maskp2;
            }
            else
            {
                nmod = nmod & ~maskp2;
            }
            if (p2start == 1)
            {
                nmod = nmod | maskp1;
            }
            else
            {
                nmod = nmod & ~maskp1;
            }
        }
        Console.WriteLine(nmod);  
    }
}
