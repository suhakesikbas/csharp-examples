using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace _06_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi Tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            // Dizilere değer atamam ve erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Döngülerde dizi kullanımı
            // Klavyeden n tane girilen sayının ortalamsını hesaplayan program
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz.");
            int diziUzunluk = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunluk];
            for (int i = 0; i < diziUzunluk; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz : ", i);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
                toplam += sayi;

            Console.WriteLine("Ortalama : {0}", toplam / diziUzunluk);

            int[] sayiDizisi2 = { 23, 2, 4, 86, 72, 3, 11, 17 };
            Console.WriteLine("****  Sırasız Dizi  ****");
            foreach (var sayi in sayiDizisi2)
                Console.WriteLine(sayi);

            Console.WriteLine("****  Sıralı Dizi  ****");
            Array.Sort(sayiDizisi2);
            foreach (var sayi in sayiDizisi2)
                Console.WriteLine(sayi);

            Console.WriteLine("****  Array Clear  ****");
            Array.Clear(sayiDizisi2, 2, 2);
            foreach (var sayi in sayiDizisi2)
                Console.WriteLine(sayi);

            Console.WriteLine("****  Array Reverse  ****");
            Array.Reverse(sayiDizisi2);
            foreach (var sayi in sayiDizisi2)
                Console.WriteLine(sayi);

            Console.WriteLine("****  Array IndexOf  ****");
            Console.WriteLine(Array.IndexOf(sayiDizisi2, 23));

            Console.WriteLine("****  Array Reverse  ****");
            Array.Resize<int>(ref sayiDizisi2, 9);
            sayiDizisi2[8] = 99;
            foreach (var sayi in sayiDizisi2)
                Console.WriteLine(sayi);

        }
    }
}
