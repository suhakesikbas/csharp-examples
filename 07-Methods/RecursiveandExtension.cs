using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace _07_Methods
{
    public static class RecursiveAndExtensionMethod
    {
        public static void Example()
        {
            Math math = new Math();
            var resultFactoriel = math.Factoriel(5);
            Console.WriteLine(resultFactoriel);
            var resultExpo = math.Expo(4, 2);
            Console.WriteLine(resultExpo);
            string param = "Lorem ipsum dolar sit amet.";
            Console.WriteLine(param.CheckSpace());
            Console.WriteLine(param.RemoveWhiteSpaces());
            Console.WriteLine(param.TextReverse());

            Console.WriteLine("Kimlik numaranızı girin.");
            int[] arr = Console.ReadLine().Select(x => Int32.Parse(x.ToString())).ToArray();
            Console.WriteLine(arr.isIdentityNumber());
        }
    }

    public class Math
    {
        public int Factoriel(int n) => (n == 1 || n == 0) ? 1 : n * Factoriel(n - 1);
        public int Expo(int basex, int a) => (a < 2) ? basex : Expo(basex, a - 1) * basex;
    }

    public static class Extensions
    {
        public static bool CheckSpace(this string param) => param.Contains(" ");
        public static string RemoveWhiteSpaces(this string param) => param.Trim().Replace(" ", string.Empty);
        public static string TextReverse(this string param)
        {
            char[] arr = param.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static bool isIdentityNumber(this int[] param)
        {
            if (param.Length < 11 && param.Length > 11)
                return false;
            int c1, c2;
            c1 = ((param[0] + param[2] + param[4] + param[6] + param[8]) * 7 - (param[1] + param[3] + param[5] + param[7])) % 10;
            c2 = (param[0] + param[1] + param[2] + param[3] + param[4] + param[5] + param[6] + param[7] + param[8] + c1) % 10;
            if (param[9] == c1 && param[10] == c2)
                return true;

            return false;

        }
    }
}
