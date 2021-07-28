using System;
using System.Collections.Generic;
namespace Examples
{
    public static class Example2
    {
        public static void Init()
        {
            Console.WriteLine("Pozitif iki sayı girin.");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} adet pozitif sayı girin.", n);
            List<int> arr = new List<int>();
            for (int i = 0; i < n; i++)
                arr.Add(int.Parse(Console.ReadLine()));


            for (int i = 0; i < n; i++)
            {
                if (arr[i] % m == 0 || arr[i] == m)
                    Console.WriteLine(arr[i]);
            }

        }
    }
}
