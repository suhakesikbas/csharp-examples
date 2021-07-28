using System;
using System.Collections.Generic;
namespace Examples
{
    public static class Example
    {
        public static void Init()
        {
            Console.WriteLine("Pozitif bir sayı girin.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} adet pozitif sayı girin.", n);
            List<int> arr = new List<int>();
            for (int i = 0; i < n; i++)
                arr.Add(int.Parse(Console.ReadLine()));
            for (int i = 0; i < n; i++)
            {
                if (arr[i]%2 == 0)
                    Console.WriteLine(arr[i]);
            }
            
        }
    }
}
