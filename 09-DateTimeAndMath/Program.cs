using System;

namespace _09_DateTimeAndMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** DateTime Kütüphanesi ***********");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddYears(1));
            Console.WriteLine(DateTime.Now.AddMonths(3));
            Console.WriteLine(DateTime.Now.AddDays(15));
            Console.WriteLine(DateTime.Now.AddHours(24));
            Console.WriteLine(DateTime.Now.AddMinutes(60));
            Console.WriteLine(DateTime.Now.AddSeconds(300));

            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //29
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Thu
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Thursday

            Console.WriteLine(DateTime.Now.ToString("MM")); //07
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Jul
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // July

            Console.WriteLine(DateTime.Now.ToString("yy")); // 21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2021

            //Math Kütüphanesi
            Console.WriteLine("*********** Math Kütüphanesi ***********");
            Console.WriteLine(Math.Abs(-25)); // |-25|
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3)); //23
            Console.WriteLine(Math.Round(22.3)); // 22
            Console.WriteLine(Math.Round(22.7)); // 23
            Console.WriteLine(Math.Floor(22.7)); // 22

            Console.WriteLine(Math.Max(2, 5));
            Console.WriteLine(Math.Min(2, 5));

            Console.WriteLine(Math.Pow(4,2)); // Üs
            Console.WriteLine(Math.Sqrt(9));// Karekök
            Console.WriteLine(Math.Log(9)); // 9'un e tabanındaki logoritmik karşılığını getirir
            Console.WriteLine(Math.Exp(3)); // e üzeri 3'ü verir.
            Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığıgi
        }
    }
}
