// Demonstrasi operator geser << dan >>.
using System;

class DemoGeser
{
    static void Main()
    {
        int nil = 1;
        int nil1 = 1;
        for (int i = 0; i < 8; i++)
        {
            for (int t = 128; t > 0; t = t / 2)
            {
                if ((nil & t) != 0) Console.Write("1 ");
                if ((nil & t) == 0) Console.Write("0 ");
            }
            Console.WriteLine();
            nil = nil << 1; // geser kiri
        }

        Console.WriteLine();
        nil = 128;
       for (int i = 0; i < 8; i++)
            {
                for (int t = 128; t > 0; t = t / 2)
                {
                    if ((nil & t) != 0) Console.Write("1 ");
                    if ((nil & t) == 0) Console.Write("0 ");
                }
                Console.WriteLine();
                nil = nil >> 1; // geser kiri
            }
       Console.WriteLine();
       nil = 128;
       for (int i = 0; i < 8; i++)
       {
           for (int t = 128; t > 0; t = t / 2)
           {
               if ((nil & t) != 0) Console.Write("1 ");
               if ((nil & t) == 0) Console.Write("0 ");
           }
           Console.WriteLine();
           nil = nil >> 1; // geser kiri
           nil = nil << 1; // geser kiri
       }
       Console.WriteLine();
       nil = 1;
       nil1 = 1;
       for (int i = 0; i < 8; i++)
       {
           for (int t = 128; t > 0; t = t / 2)
           {
               if ((nil & t) != 0) Console.Write("1 ");
               if ((nil & t) == 0) Console.Write("0 ");
           }
           Console.WriteLine();
           nil1 = nil1 << 1; // geser kiri
           nil = nil | 1;

       }
       Console.WriteLine();
       nil = 129;
       nil1 = 129;
       for (int i = 0; i < 8; i++)
       {
           for (int t = 128; t > 0; t = t / 2)
           {
               if ((nil & t) != 0) Console.Write("1 ");
               if ((nil & t) == 0) Console.Write("0 ");
           }
           Console.WriteLine();
           nil1 = nil1 >> 1; // geser kiri
           nil = nil | 1 ;       
       }
       Console.WriteLine();
       nil = 1;
       nil1 = 1;
       for (int i = 8; i < 8; i++)
       {
           for (int t = 128; t > 0; t = t / 2)
           {
               if ((nil & t) != 0) Console.Write("1 ");
               if ((nil & t) == 0) Console.Write("0 ");
           }
           Console.WriteLine();
           nil1 = nil1 << 1; // geser kiri
           nil = nil | 1;

       }
    }
}