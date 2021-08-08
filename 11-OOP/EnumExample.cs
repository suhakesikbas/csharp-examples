using System;

namespace _11_OOP
{
    public static class EnumExample
    {
        public static void Init()
        {
            Console.WriteLine("{0} {1}", (int)Gunler.Pazar, Gunler.Pazar);

            int sicaklik = 5;

            if (sicaklik <= (int)HavaDurumu.Soguk)
            {
                Console.WriteLine("Dışarıya çıkmak için soğuk bir hava.");
            }
            else if (sicaklik <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekle.");
            }
            else if (sicaklik <= (int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Dışarıya çıkmak için ideal bir hava.");
            }
            else if (sicaklik <= (int)HavaDurumu.CokSicak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir hava.");
            }
        }
    }

    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSicak = 30
    }
}