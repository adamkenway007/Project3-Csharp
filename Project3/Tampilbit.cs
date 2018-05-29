// Menampilkan bit-bit dalam sebuah byte.
using System;

class TampilBit
{
    static void Main() {
        int t;
        byte nil;

        nil = 123;
        for(t=128; t > 0; t = t/2) {
            if((nil & t) != 0) Console.Write("l ");
            if ((nil & t) == 0) Console.Write("0 ");
            Console.WriteLine("\t");
        }
    }
}