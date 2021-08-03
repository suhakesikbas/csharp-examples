using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace _10_Collections
{
    public static class GenericListExample
    {
        public static void Example()
        {
         // List<T> class
            // System.Collections.Generic;
            // T- Object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            foreach (var item in sayiListesi)
                Console.WriteLine(item);
            foreach (var item in renkListesi)
                Console.WriteLine(item);

            //Listeden eleman çıkarma
            sayiListesi.Remove(23);
            renkListesi.Remove("Kırmızı");
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(0);


            sayiListesi.ForEach(s=>Console.WriteLine(s));
            renkListesi.ForEach(r=>Console.WriteLine(r));

            //Liste içerisinde arama
            if (renkListesi.Contains("Yeşil"))
                Console.WriteLine("Listede yeşil renk var.");

            // Eleman ile indise erişim
            //Console.WriteLine(renkListesi.BinarySerach("Yeşil"));

            // Diziyi listeye çevirme
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Liste temizleme
            hayvanListesi.Clear();

            // list içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar{
                Isım = "Ayşe",
                Soyisim="Yılmaz",
                Yas=30
            };
            Kullanicilar kullanici2 = new Kullanicilar{
                Isım = "Hakan",
                Soyisim="Salih",
                Yas=30
            };
            Kullanicilar kullanici3 = new Kullanicilar{
                Isım = "Turgut",
                Soyisim="Kurt",
                Yas=30
            };
            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);
            kullaniciListesi.Add(kullanici3);

            foreach (var item in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: "+ item.Isım);
                Console.WriteLine("Kullanıcı Soyadı: "+ item.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı: "+ item.Yas);
            }
        }
    }
    public class Kullanicilar{
        string isim;
        string soyisim;
        int yas;

        public string Isım { get => isim; set => isim = value; }
        public string Soyisim { get=> soyisim; set=>soyisim=value; }
        public int Yas { get=>yas; set=>yas = value; }
    }
}
