// Menggunakan AND bitwise untuk membuat angka genap.
using System;

class MembuatGenap
{
    static void Main()
    {
        ushort angka;
        ushort i;

        for (i = 1; i <= 10; i++)
        {
            angka = i;

            Console.WriteLine("angka: " + angka);

            angka = (ushort)(angka & 0xFFFE);

            Console.WriteLine("angka setelah menon-aktifkan bit LSB: " + angka + "\n");
        }
    }
}