// Membuat OR bitwise untuk membuat sebuah angka menjadi ganjil
using System;

class MembuatGanjil
{
    static void Main()
    {
        ushort angka;
        ushort i;

        for (i = 1; i <= 10; i++)
        {
            angka = i;
            Console.WriteLine("angka: " + angka);

            angka = (ushort)(angka | 1);
            Console.WriteLine("angka setelah mengaktifkan bit LSB: " + angka + "\n");
        }
    }
}