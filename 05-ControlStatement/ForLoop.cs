using System;

namespace _05_ControlStatement
{
    public static class ForLoop
    {
        public static void ForLoopExample()
        {
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                Console.WriteLine(i);
            }

            // 1 ile 1000 arasındaki tek ve çift sayıların toplamını yazınız.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i; // tekToplam=tekToplam+i
                }
                else
                {
                    ciftToplam += i;// ciftToplam=ciftToplam+i
                }
            }

            Console.WriteLine("Tek toplam = {0}", tekToplam);
            Console.WriteLine("Çift toplam = {0}", ciftToplam);

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }

        }
    }
}
