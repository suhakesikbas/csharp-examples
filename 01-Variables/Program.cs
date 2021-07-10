using System;

namespace _01_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1; 
            sbyte c = 1;
            short s = 2;
            ushort us = 2;

            Int16 i16 = 2;
            int i = 4;
            Int32 i32 = 4;
            Int64 i64 = 8;

            uint ui = 4;
            long l =8;
            ulong ul = 8;

            float f =4;
            double d = 8;
            decimal de = 16; 

            char ch = '?';
            string str = "Lorem ipsum dolar sit amet.";

            bool b1 = true;
            bool b2 = false; 

            // DateTime
            DateTime dt = DateTime.Now;

            //Object
            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 3.6;

            //String
            string str1 = string.Empty;
            str1 = "Suha";
            string ad = "Suha";
            string soyad = "Kesikbaş";
            string tam_ad = ad +" "+ soyad;

            //Integer
            int integer1 = 3;
            int integer2 = 5;
            int integer = integer1*integer2;

            //Boolean
            bool bl = 10 <2;

            //Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string str20i = str20 + int20.ToString();
            Console.WriteLine(str20i);

            int int20i = Convert.ToInt32(str20) + int20;
            Console.WriteLine(int20i);

            int int21 = int20 + int.Parse(str20);

            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");
            
        }
    }
}
