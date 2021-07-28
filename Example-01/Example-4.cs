using System;
using System.Linq;
using System.Collections.Generic;
namespace Examples
{
    public static class Example4
    {
        public static void Init()
        {
            Console.WriteLine("Bir cümle yazın.");
            string input = Console.ReadLine();
            int word_count = input.Split(' ').Length;
            int letter_count = input.Replace(" ", "").Length;
            Console.WriteLine($"Cümlenizde {word_count} adet kelime {letter_count} adet harf bulunmaktadır.");

        }
    }
}
