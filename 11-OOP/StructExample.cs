using System;

namespace _11_OOP
{
    public static class StructExample
    {

        public static void Init()
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;
            Console.WriteLine("Dikdörtgennin alan uzunluğu : {0}", dikdortgen.AlanHesapla());
        }

        struct Dikdortgen
        {
            public int KisaKenar { get; set; }
            public int UzunKenar { get; set; }

            public Dikdortgen(int kisaKenar, int uzunKenar)
            {
                KisaKenar = kisaKenar;
                UzunKenar = uzunKenar;
            }

            public long AlanHesapla()
            {
                return this.KisaKenar * this.UzunKenar;
            }

        }
    }
}