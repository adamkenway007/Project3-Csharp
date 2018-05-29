// Demonstrasi operator relasional dan logika.
using System;

class OpRelLog
{
    static void Main()
    {
        int i, j;
        bool b1, b2;
        i = 10;
        j = 11;

        if (i < j) Console.WriteLine("i < j");
        if (i <= j) Console.WriteLine("i <= j");
        if (i != j) Console.WriteLine("i != j");
        if (i == j) Console.WriteLine("ini tidak akan dieksekusi");
        if (i >= j) Console.WriteLine("ini tidak akan dieksekusi");
        if (i > j) Console.WriteLine("ini tidak akan dieksekusi");

        b1 = true;
        b2 = false;
        if (b1 & b2) Console.WriteLine("ini tidak akan dieksekusi");
        if (!(b1 & b2)) Console.WriteLine("!(b1 & b2) bernilai true");
        if (b1 | b2) Console.WriteLine("b1 | b2 bernilai true");
        if (b1 ^ b2) Console.WriteLine("b1 ^ b2 bernilai true");
    }
}