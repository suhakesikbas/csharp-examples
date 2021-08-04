using System;
using System.Collections;
using System.Linq;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeNumberList = new ArrayList();
            ArrayList notPrimeNumberList = new ArrayList();
            Console.WriteLine("20 pozitif sayı giriniz.");
            for (int i = 0; i < 20; i++)
            {
                int num;
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    var result = num.IsPrimeNumber();
                    if (num > 0
                    && !primeNumberList.Contains(num)
                    && !notPrimeNumberList.Contains(num))
                    {
                        if (result)
                            primeNumberList.Add(num);
                        else
                            notPrimeNumberList.Add(num);
                    }
                }
            }
            if (primeNumberList.Count > 0)
            {
                Console.WriteLine("******* Asal Sayılar *******");
                primeNumberList.Sort();
                foreach (var item in primeNumberList)
                    Console.WriteLine(item);
                Console.WriteLine("Asal sayı listesi eleman sayısı : {0} ortalaması : {1}", primeNumberList.Count, primeNumberList.Average());
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayıların hiçbiri asal sayı değil!");
            }
            if (notPrimeNumberList.Count > 0)
            {
                Console.WriteLine("******* Asal Olmayan Sayılar *******");
                notPrimeNumberList.Sort();
                foreach (var item in notPrimeNumberList)
                    Console.WriteLine(item);
                Console.WriteLine("Asal olmayan sayı listesi eleman sayısı : {0} ortalaması : {1}", notPrimeNumberList.Count, notPrimeNumberList.Average());
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayıların herbiri asal sayı");
            }
        }


    }
    static class Extension
    {
        public static bool IsPrimeNumber(this int num)
        {
            int i, m = 0;
            m = num / 2;
            for (i = 2; i <= m; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public static decimal Average(this ArrayList list)
        {
            return list.Sum() / list.Count;
        }

        public static int Sum(this ArrayList list)
        {
            int result = 0;
            foreach (var item in list)
                result += Convert.ToInt32(item);
            return result;
        }
    }
}
