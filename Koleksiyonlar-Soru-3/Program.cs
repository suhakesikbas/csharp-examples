using System;
using System.Collections.Generic;
using System.Linq;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sesliHarfler = new HashSet<char> { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            Console.WriteLine("Bir cümle yazın");
            string cumle = Console.ReadLine();
            char[] bulunanHarfler = cumle.Where(c=>sesliHarfler.Contains(c)).ToArray();

            Array.Sort(bulunanHarfler);
            for (int i = 0; i < bulunanHarfler.Length; i++)
                Console.WriteLine(bulunanHarfler[i]);


        }
    }
}
