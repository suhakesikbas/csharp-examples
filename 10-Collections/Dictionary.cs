using System;
using System.Collections;
using System.Collections.Generic;

namespace _10_Collections
{
    public static class DictionaryExample
    {
        public static void Example()
        {
            //System.Collections.Generic
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(1, "Akın");
            kullanicilar.Add(3, "Salih");
            kullanicilar.Add(5, "Murat");
            kullanicilar.Add(9, "Şevki");

            //Dizinin elemanlarına erişim
            Console.WriteLine("*************  Elemanlara Erişim  *************");
            Console.WriteLine(kullanicilar[3]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Eleman sayısı
            Console.WriteLine("*************  Count  *************");
            Console.WriteLine(kullanicilar.Count);

            //Eleman Arama
            Console.WriteLine("*************  Contains  *************");
            Console.WriteLine(kullanicilar.ContainsKey(2));
            Console.WriteLine(kullanicilar.ContainsValue("Şevki"));

            //Remove
            Console.WriteLine("*************  Remove  *************");
            kullanicilar.Remove(3);
            foreach (var item in kullanicilar)
                Console.WriteLine(item.Value);

            //Key
            Console.WriteLine("*************  Key  *************");
            foreach (var item in kullanicilar)
                Console.WriteLine(item.Key);


            //Value
            Console.WriteLine("*************  Value  *************");
            foreach (var item in kullanicilar)
                Console.WriteLine(item.Value);

        }
    }
}
