using System;

namespace _05_ControlStatement
{
    public static class WhileLoop
    {
        public static void WhileExample()
        {
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            //A'dan Z'ye kadar tüm harfleri yazdır.;
            char character = 'a';
            while (character <= 'z')
            {
                Console.WriteLine(character);
                character++;
            }

            Console.WriteLine("*********Foreach***********");

            string[] cars = {"Toyota","Kia","Hyundai","Nissan","Renault"};

            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }

        }
    }
}
