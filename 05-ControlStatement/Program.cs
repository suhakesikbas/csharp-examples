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
            string sonuc = time >= 6 && time < 11 ?"Günaydın": time <11 ?"İyi Günler!":"İyi Geceler!";
            Console.WriteLine(sonuc);
        }
    }
}
