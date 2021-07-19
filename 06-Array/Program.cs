using System;

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
            dizi[3]=10;
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
                toplam+=sayi;

            Console.WriteLine("Ortalama : {0}", toplam/diziUzunluk);

        }
    }
}
