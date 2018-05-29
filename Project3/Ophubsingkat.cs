// Demonstrasi operator hubungan-singkat.
using System;

class OpHubSingkat
{
    static void Main() {
        int  n, d;

        n = 10;
        d = 2;
        if (d != 0 && (n % d) == 0)
            Console.WriteLine(d + " adalah faktor dari " + n);

        d = 0; // sekarang, tetapkan d menjadi nol

        // karena d bernilai nol, maka operand kedua tidak dievaluasi.
        if (d != 0 && (n % d) == 0)
            Console.WriteLine(d + " adalah faktor dari " + n);

        // sekarang. coba hal yang sama tanpa operator hubungan-singkat.
        // ini akan menyebabkan error pembagian-oleh-nol.
        if (d != 0 && (n % d) == 0)
            Console.WriteLine(d + " adalah faktor dari " + n);
    }
}