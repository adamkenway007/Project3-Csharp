// Demo XOR.
using System;

class Encode {
    static void Main() {
    char ch1 = 'B';
    char ch2 = 'A';
    char ch3 = 'H';
    int key = 88;

    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.WriteLine("Real text: " + ch1 + ch2 + ch3);

    // Decoding Text
    ch1 = (char)(ch1 ^  key);
    ch2 = (char)(ch2 ^  key);
    ch3 = (char)(ch3 ^  key);

    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.WriteLine("Encoded text: " + ch1 + ch2 + ch3);

    // Encoding Text
    ch1 = (char) (ch1 ^ key);
    ch2 = (char)(ch2 ^  key);
    ch3 = (char)(ch3 ^  key);

    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.WriteLine("Decoded text: " + ch1 + ch2 + ch3);
    }
}
