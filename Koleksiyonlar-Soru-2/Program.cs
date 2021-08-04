using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            int[] maxNumbers = new int[3];
            int[] minNumbers = new int[3];
            Console.WriteLine("20 adet sayı giriniz.");
            for (int i = 0; i < 20; i++)
            {
                int num;
                if (int.TryParse(Console.ReadLine(), out num))
                    numbers[i] = num;
            }
            
            Array.Sort(numbers);
            minNumbers.AddRange(numbers.Take(3));
            Array.Reverse(numbers);
            maxNumbers.AddRange(numbers.Take(3));

            int minAvg = minNumbers.Average();
            int maxAvg = maxNumbers.Average();
            Console.WriteLine("Minimum 3 sayının ortalaması : {0}", minAvg);
            Console.WriteLine("Maksimum 3 sayının ortalaması : {0}", maxAvg);
            Console.WriteLine("Ortalama toplamları : {0}", minAvg + maxAvg);
        }
    }
}

static class Extension
{

    public static int Average(this int[] list)
    {
        return list.Sum() / list.Length;
    }

    public static int Sum(this int[] list)
    {
        int result = 0;
        foreach (var item in list)
            result += item;
        return result;
    }

    public static int[] Take(this int[] list, int count)
    {
        int[] result = new int[3];
        for (int i = 0; i < count; i++)
            result[i] = list[i];
        return result;
    }

    public static void AddRange(this int[] list, int[] newList)
    {
        for (int i = 0; i < newList.Length; i++)
            list[i] = newList[i];
    }
}
