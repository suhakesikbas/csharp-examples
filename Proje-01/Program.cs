using System;
using System.Collections.Generic;
using System.Linq;

namespace Proje_01
{
    class Program
    {
        static List<Kisi> telefonRehberi;
        static void Main(string[] args)
        {
            telefonRehberi = TelefonRehberiGetir();
            MenuGetir();
        }

        public static List<Kisi> TelefonRehberiGetir()
        {
            return new List<Kisi>{
                new Kisi{
                    Isim="Kass",
                    Soyisim="Birkin",
                    TelefonNumarasi = "866-342-3868"
                },
                new Kisi{
                    Isim="Yoko",
                    Soyisim="Winckworth",
                    TelefonNumarasi = "882-396-2249"
                },
                new Kisi{
                    Isim="Nicko",
                    Soyisim="Wegenen",
                    TelefonNumarasi = "739-285-4003"
                },
                new Kisi{
                    Isim="Johanna",
                    Soyisim="MacGillivrie",
                    TelefonNumarasi = "493-640-7990"
                },
                new Kisi{
                    Isim="Moore",
                    Soyisim="Lurner",
                    TelefonNumarasi = "236-756-3698"
                }
            };
        }

        public static void MenuGetir()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            int secim;
            if (int.TryParse(Console.ReadLine(), out secim))
            {
                switch (secim)
                {
                    case 1:
                        RehberKayitEkle();
                        break;
                    case 2:
                        RehberKayitSil();
                        break;
                    case 3:
                        RehberKayitGuncelle();
                        break;
                    case 4:
                        RehberKayitListele(telefonRehberi);
                        break;
                    case 5:
                        RehberKayitArama();
                        break;
                    default:
                        MenuGetir();
                        break;
                }
            }
            else
                MenuGetir();
        }

        public static void RehberKayitEkle()
        {
            Kisi yeniKisi = new Kisi();
            Console.WriteLine(" Lütfen isim giriniz             :");
            yeniKisi.Isim = Console.ReadLine();
            Console.WriteLine(" Lütfen soyisim giriniz          :");
            yeniKisi.Soyisim = Console.ReadLine();
            Console.WriteLine(" Lütfen telefon numarası giriniz :");
            yeniKisi.TelefonNumarasi = Console.ReadLine();
            telefonRehberi.Add(yeniKisi);
            MenuGetir();
        }

        public static void RehberKayitSil()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string terim = Console.ReadLine().ToLower();
            var sonuc = telefonRehberi.FirstOrDefault(
                t => t.Isim.ToLower().Contains(terim)
                || t.Soyisim.ToLower().Contains(terim));
            if (sonuc != null)
            {
                Console.WriteLine($"{sonuc.Isim} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                string secim = Console.ReadLine();
                if (secim == "y")
                    telefonRehberi.Remove(sonuc);
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Silmeyi sonlandırmak için : (1)");
                Console.WriteLine(" * Yeniden denemek için      : (2)");
                int secim;
                if (int.TryParse(Console.ReadLine(), out secim))
                {
                    if (secim == 2)
                        RehberKayitSil();
                }
            }
            MenuGetir();
        }

        public static void RehberKayitGuncelle()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string terim = Console.ReadLine().ToLower();
            var sonuc = telefonRehberi.FirstOrDefault(
                t => t.Isim.ToLower().Contains(terim)
                || t.Soyisim.ToLower().Contains(terim));
            if (sonuc != null)
            {
                Console.WriteLine("Not: Güncellemek istemediğiniz alanları boş geçiniz.");
                
                Console.WriteLine(" Lütfen yeni isim giriniz             :");
                string isim = Console.ReadLine();
                if (!string.IsNullOrEmpty(isim))
                    sonuc.Isim = isim;

                Console.WriteLine(" Lütfen yeni soyisim giriniz          :");
                string soyisim = Console.ReadLine();
                if (!string.IsNullOrEmpty(soyisim))
                    sonuc.Soyisim = soyisim;

                Console.WriteLine(" Lütfen yeni telefon numarası giriniz :");
                string telefonNumarasi = Console.ReadLine();
                if (!string.IsNullOrEmpty(telefonNumarasi))
                    sonuc.TelefonNumarasi = telefonNumarasi;
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine(" * Yeniden denemek için      : (2)");
                int secim;
                if (int.TryParse(Console.ReadLine(), out secim))
                {
                    if (secim == 2)
                        RehberKayitGuncelle();
                }
            }
            MenuGetir();
        }

        public static void RehberKayitListele(List<Kisi> liste)
        {
            foreach (var item in liste)
            {
                Console.WriteLine($"isim: {item.Isim}");
                Console.WriteLine($"Soyisim: {item.Soyisim}");
                Console.WriteLine($"Telefon Numarası: {item.TelefonNumarasi}");
                Console.WriteLine("-");
            }
            MenuGetir();
        }

        public static void RehberKayitArama()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int secim;
            if (int.TryParse(Console.ReadLine(), out secim))
            {
                List<Kisi> sonucListe = new List<Kisi>();
                Console.WriteLine("Arama istediğiniz {0} giriniz.", secim == 1 ? "isime veya soyisimi" : "telefon numarasını");
                string terim = Console.ReadLine().ToLower();
                if (secim == 1)
                {
                    sonucListe = telefonRehberi.Where(
                                        t => t.Isim.ToLower().Contains(terim)
                                        || t.Soyisim.ToLower().Contains(terim)).ToList();

                }
                else if (secim == 2)
                {
                    sonucListe = telefonRehberi.Where(
                                   t => t.TelefonNumarasi.Replace(" ", "").Replace("-", "")
                                   .Contains(terim.Replace(" ", "").Replace("-", ""))).ToList();
                }

                if (sonucListe.Count > 0)
                {
                    Console.WriteLine("Arama Sonucu");
                    Console.WriteLine("**********************************************");
                    RehberKayitListele(sonucListe);
                }
                else
                {
                    Console.WriteLine("Arama kriterinize uygun sonuç bulunamadı.");
                }
            }
            MenuGetir();
        }
    }
}
