// Mencegah pembagian oleh nol menggunakan ?.
using System;

class JgnBagiNol
{
    static void Main()
    {
        int hasil;

        for (int i = -5; i < 6; i++)
        {
            hasil = i != 0 ? 100 / i : 0;
            if (i != 0)
                Console.WriteLine("100 / " + i + " adalah " + hasil);
        }
    }
}