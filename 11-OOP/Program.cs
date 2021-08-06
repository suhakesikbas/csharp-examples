﻿using System;

namespace _11_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Salih", "Arslan", "BI");
            calisan1.CalisanBilgileri();
            Calisan calisan2 = new Calisan("Melek", "Soylu", "IK");
            calisan2.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string _ad;
        public string _soyad;
        public string _departman;
        public Calisan(string ad, string soyad, string departman)
        {
            _ad = ad;
            _soyad = soyad;
            _departman = departman;
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine($"Çalışan Bilgileri");
            Console.WriteLine($"Ad Soyad : {_ad} {_soyad}");
            Console.WriteLine($"Departman: {_departman}");
        }

    }
}