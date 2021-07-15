using System;

namespace _05_ControlStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Günaydın!");
            }
            else if (time < 11)
            {
                Console.WriteLine("İyi Günler!");
            }
            else
            {
                Console.WriteLine("İyi Geceler!");
            }

            //string sonuc = time <=18 ?"İyi Günler!":"İyi Geceler!";
            string sonuc = time >= 6 && time < 11 ? "Günaydın" : time < 11 ? "İyi Günler!" : "İyi Geceler!";
            Console.WriteLine(sonuc);

            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Mayıs Ayındasınız.");
                    break;
                case 2:
                    Console.WriteLine("Haziran Ayındasınız.");
                    break;
                case 3:
                    Console.WriteLine("Temmuz Ayındasınız.");
                    break;
                case 7:
                    Console.WriteLine("Ağustos Ayındasınız.");
                    break;

                default:
                    Console.WriteLine("Yanlış veri girişi");
                    break;
            }

            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Kış Mevsimi.");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("İlkbahar Mevsimi");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Yaz Mevsimi.");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Sonbahar Mevsimi.");
                    break;
            }

        }
    }
}
