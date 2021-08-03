using System;
using System.Collections;
using System.Collections.Generic;

namespace _10_Collections
{
    public static class ArrayListExample
    {
        public static void Example()
        {
            ArrayList arraylist = new ArrayList();
            // arraylist.Add("Ayşe");
            // arraylist.Add(2);
            // arraylist.Add(true);
            // arraylist.Add('A');

            //içerisindeki verilere erişim
            //Console.WriteLine(arraylist[1]);

            foreach (var item in arraylist)
                Console.WriteLine(item);

            //Addrange
            Console.WriteLine("********* AddRange *********");
            //string[] renkler = {"Sarı", "Kırmızı", "Mavi", "Yeşil"};
            List<int> sayilar = new List<int>(){2,15,4,54,6,99,8,10};
            //arraylist.AddRange(renkler);
            arraylist.AddRange(sayilar);

            foreach (var item in arraylist)
                Console.WriteLine(item);

            // Sort
            Console.WriteLine("********* Sort *********");
            arraylist.Sort();

            foreach (var item in arraylist)
                Console.WriteLine(item);

             // Binary Search
            Console.WriteLine("********* Binary Search *********");
            Console.WriteLine(arraylist.BinarySearch(10));

             // Reverse
            Console.WriteLine("********* Reverse *********");
            arraylist.Reverse();
            foreach (var item in arraylist)
                Console.WriteLine(item);

// Clear
            Console.WriteLine("********* Clear *********");
            arraylist.Clear();
            foreach (var item in arraylist)
                Console.WriteLine(item);

        }
    }
}
