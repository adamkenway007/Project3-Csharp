// Membagi hanya dengan angka genap, tak-nol.
using System;

class Nozerodiv2
{
    static void Main()
    {
        for (int i = -5; i < 6; i++)
            if (i != 0 ? (i % 2 == 0) : false)
                Console.WriteLine("100 / " + " adalah " + 100 / i);
    }
}