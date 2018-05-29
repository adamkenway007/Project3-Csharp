// Menggunakan operator penggeseran untuk mengkalikan dan membagi dengan 2.
using System;

class KaliBagi
{
    static void Main() {
    int n;

    n = 10;
    Console.WriteLine("Nilai dari n: " + n);

    // Mengkalikan dengan 2.
    n = n << 1;
    Console.WriteLine("Nilai dari n setelah n = n * 2: " + n);
    
    // Mengkalikan dengan 4.
    n = n << 2;
    Console.WriteLine("Nilai dari n setelah n = n * 4: " + n);

    // Membagi dengan 2.
    n = n >> 1;
    Console.WriteLine("Nilai dari n setelah n = n / 2: " + n);

    // Membagi dengan 4.
    n = n >> 2;
    Console.WriteLine("Nilai dari n setelah n = n / 4: " + n);
    Console.WriteLine();

    // Reset 4.
    n = 10;
    Console.WriteLine("Nilai dari n: " + n);

    // Mengalikan dengan 2, 30 kali.
    n = n << 30; // data hilang
    Console.WriteLine("Nilai dari n setelah penggeseran 30 posisi: " + n);
    }
}