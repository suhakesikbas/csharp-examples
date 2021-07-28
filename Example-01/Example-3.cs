using System;
using System.Linq;
using System.Collections.Generic;
namespace Examples
{
    public static class Example3
    {
        public static void Init()
        {
            Console.WriteLine("Pozitif bir sayı girin.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} adet kelime girin.", n);
            List<string> arr = new List<string>();
            for (int i = 0; i < n; i++)
                arr.Add(Console.ReadLine());

            //for (int i = n; i > 0; i--)
            //    Console.WriteLine(arr[i - 1]);

            arr.Reverse();
            arr.ForEach(w => Console.WriteLine(w));

        }
    }
}
