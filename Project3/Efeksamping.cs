// Efek samping bisa berguna.
using System;

class EfekSamping
{
    static void Main()
    {
        int i;
        bool suatuKondisi = false;
        i = 0;

        // Di sini, i masih diinkremen meski if gagal.
        if (suatuKondisi & (++i < 100))
            Console.WriteLine("ini tidak akan ditampilkan");
        Console.WriteLine("statemen if dieksekusi: " + i); // menampilkan 1

        // Pada kasus ini, i tidak diinkremen karena operator
        // hubungan-singkat melompati inkremen.
        if (suatuKondisi && (++i < 100))
            Console.WriteLine("ini tidak akan ditampilkan");
        Console.WriteLine("statemen if dieksekusi: " + i); // masih 1!!
    }
}
