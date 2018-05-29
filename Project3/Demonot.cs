// Demonstrasi NOT bitwise.
using System;

class DemoNot
{
    static void Main()
    {
        sbyte b = -34;

        for (int t = 128; t > 0; t = t / 2)
        {
            if ((b & t) != 0) Console.Write("1 ");
            if ((b & t) == 0) Console.Write("0 ");
        }

        Console.WriteLine();

        // menbalikkan semua bit
        b = (sbyte)~b;
        for (int t = 128; t > 0; t = t / 2)
        {
            if ((b & t) != 0) Console.Write("1 ");
            if ((b & t) == 0) Console.Write("0 ");
        }
        Console.WriteLine("\t");
    }
}