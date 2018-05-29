// Demonstrasi perbedaan antara format prefiks
// dan format postfix dari ++.
using System;

class DemoPrePost
{
    static void Main()
    {
        int x, y;
        int i;

        x = 1;
        y = 0;
        Console.WriteLine("Deret yang dihasilkan mengunakan y = y + x++;");
        for (i = 0; i < 10; i++)
        {
            y = y + x++; // postfix ++

            Console.WriteLine(y + " ");
        }

        Console.WriteLine();

        x = 1;
        y = 0;
        Console.WriteLine("Deret yang dihasilkan mengunakan y = y + ++x;");
        for (i = 0; i < 10; i++)
        {
            y = y + ++x; // prefiks ++
            Console.WriteLine(y + " ");
        }
        Console.WriteLine();
    }
}