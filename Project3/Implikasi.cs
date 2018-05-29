// Menciptakan operator implikasi dalam C#
using System;

class Implikasi
{
    static void Main()
    {
        bool p = false, q = false;
        int i, j;

        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                if (i == 0) p = true;
                if (i == 1) p = false;
                if (j == 0) q = true;
                if (j == 1) q = false;

                Console.WriteLine("p bernilai " + p + ", q bernilai " + q);
                if (!p | q) Console.WriteLine(p + " mengimplikasikan bahwa " + q + " bernilai " + true);
                Console.WriteLine();
            }
        }
    }
}