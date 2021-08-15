using System;
using System.Linq;
using System.Collections.Generic;
using Proje_02.Models;
using System.Text.RegularExpressions;

namespace Proje_02
{
    public class TodoManager
    {
        List<Kart> TodoList = new List<Kart>();
        List<Kart> InProgressList = new List<Kart>();
        List<Kart> DoneList = new List<Kart>();

        List<Kisi> KisiListesi = new List<Kisi>{
            new Kisi{Id=1,AdSoyad="Fatma Özlem"},
            new Kisi{Id=2,AdSoyad="Özde Acarkan"},
            new Kisi{Id=3,AdSoyad="Atahan Adanır"},
            new Kisi{Id=4,AdSoyad="Mehmet Adıgüzel"},
            new Kisi{Id=5,AdSoyad="Şennur Ağnar"},
            new Kisi{Id=6,AdSoyad="Mügenur Ahmet"},
            new Kisi{Id=7,AdSoyad="Cihan Akarpınar"},
            new Kisi{Id=8,AdSoyad="Servet Akçagunay"}
        };
        
        public void Init(){
            MenuGetir();
        }

        public void MenuGetir()
        {
            Console.WriteLine("  Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("  *******************************************");
            Console.WriteLine("  (1) Board Listelemek");
            Console.WriteLine("  (2) Board'a Kart Eklemek");
            Console.WriteLine("  (3) Board'dan Kart Silmek");
            Console.WriteLine("  (4) Kart Taşımak");

            int secim;
            if (int.TryParse(Console.ReadLine(), out secim))
            {
                switch (secim)
                {
                    case 1:
                        BoardListele("TODO",TodoList);
                        BoardListele("IN PROGRESS", InProgressList);
                        BoardListele("DONE", DoneList);
                        MenuGetir();
                        break;
                    case 2:
                        BoardKartEkle();
                        break;
                    case 3:
                        BoardKartSil();
                        break;
                    case 4:
                        BoardKartTasi();
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim tekrar deneyin.");
                        MenuGetir();
                        break;
                }
            }
        }
        public void BoardListele(string name, List<Kart> liste)
        {
                Console.WriteLine(" {0} Line", name);
                Console.WriteLine(" ************************");
                if (liste.Count > 0)
                {
                    foreach (var kart in liste)
                    {
                        Console.WriteLine(" Başlık      : {0}", kart.Baslik);
                        Console.WriteLine(" İçerik      : {0}", kart.Icerik);
                        Console.WriteLine(" Atanan Kişi : {0}", kart.AtananKisi.AdSoyad);
                        Console.WriteLine(" Büyüklük    : {0}", kart.Buyukluk);
                        Console.WriteLine(" - \n");
                    }
                }
                else
                    Console.WriteLine(" ~ BOŞ ~");
        }
        public void BoardKartEkle()
        {
            // Kart Oluştur
            Kart yeniKart = new Kart();
            Console.WriteLine(" Başlık Giriniz                                  : ");
            yeniKart.Baslik = Console.ReadLine();

            Console.WriteLine(" İçerik Giriniz                                  : ");
            yeniKart.Icerik = Console.ReadLine();

            Console.WriteLine(" Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
            yeniKart.Buyukluk = (Buyukluk)int.Parse(Console.ReadLine());

            // Karta ataanacak kişiyi kontrol et, id varsa ata.
            int kisiId = 0;
            Kisi atananKisi;
            do
            {
                Console.WriteLine(" Kişi Seçiniz                                    : ");
                kisiId = Convert.ToInt32(Console.ReadLine());
                atananKisi = KisiListesi.FirstOrDefault(k => k.Id == kisiId);
            }
            while (atananKisi == null);
            yeniKart.AtananKisi = atananKisi;
            // TODO listeye yeni kartı ekle.
            TodoList.Add(yeniKart);
            MenuGetir();
        }
        public void BoardKartSil()
        {
            Console.WriteLine(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine(" Lütfen kart başlığını yazınız:  ");
            string term = Console.ReadLine().ToLower();
            var sonuc = KartAra(term);
            if (sonuc.Count > 0)
            {
                Console.WriteLine("{0} adet sonuç bulundu silmek için onaylıyor musunuz ?(y/n)", sonuc.Count);
                string secim = Console.ReadLine();
                if (secim == "y")
                {
                    TodoList.RemoveAll(i => i.Baslik.ToLower() == term);
                    InProgressList.RemoveAll(i => i.Baslik.ToLower() == term);
                    DoneList.RemoveAll(i => i.Baslik.ToLower() == term);
                }
            }
            else
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Silmeyi sonlandırmak için : (1)");
                Console.WriteLine(" * Yeniden denemek için : (2)");
                int secim;
                if (int.TryParse(Console.ReadLine(), out secim) && secim == 2)
                    BoardKartSil();
            }
            MenuGetir();

        }
        public void BoardKartTasi()
        {
            Console.WriteLine(" Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine(" Lütfen kart başlığını yazınız:  ");
            string term = Console.ReadLine().ToLower();
            var sonucToDo = TodoList.Where(t => t.Baslik.ToLower() == term).ToList();
            var sonucInProgress = InProgressList.Where(t => t.Baslik.ToLower() == term).ToList();
            var sonucDone = DoneList.Where(t => t.Baslik.ToLower() == term).ToList();
            if (sonucToDo.Count > 0|| sonucInProgress.Count > 0|| sonucDone.Count > 0)
            {
                if (sonucToDo.Count > 0)
                    KartListele("TODO", sonucToDo);
                if (sonucInProgress.Count > 0)
                    KartListele("IN PROGRESS", sonucInProgress);
                if (sonucDone.Count > 0)
                    KartListele("DONE", sonucInProgress);

                Console.WriteLine(" Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                Console.WriteLine(" (1) TODO");
                Console.WriteLine(" (2) IN PROGRESS");
                Console.WriteLine(" (3) DONE");

                int secim;
                if (int.TryParse(Console.ReadLine(), out secim) && Regex.IsMatch(secim.ToString(),"[123]"))
                {
                    if (secim ==1)
                    {
                        TodoList.AddRange(sonucInProgress);
                        TodoList.AddRange(sonucDone);
                        InProgressList.RemoveAll(i => i.Baslik.ToLower() == term);
                        DoneList.RemoveAll(i => i.Baslik.ToLower() == term);
                    }
                    else if (secim == 2)
                    {
                        InProgressList.AddRange(sonucToDo);
                        InProgressList.AddRange(sonucDone);
                        TodoList.RemoveAll(i => i.Baslik.ToLower() == term);
                        DoneList.RemoveAll(i => i.Baslik.ToLower() == term);
                    }
                    else if (secim == 3)
                    {
                        DoneList.AddRange(sonucToDo);
                        DoneList.AddRange(sonucInProgress);
                        TodoList.RemoveAll(i => i.Baslik.ToLower() == term);
                        InProgressList.RemoveAll(i => i.Baslik.ToLower() == term);
                    }
                }
            }
            else
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * İşlemi sonlandırmak için : (1)");
                Console.WriteLine(" * Yeniden denemek için : (2)");
                int secim;
                if (int.TryParse(Console.ReadLine(), out secim) && secim == 2)
                    BoardKartTasi();
            }
            MenuGetir();
        }

        #region Utilities
        public List<Kart> KartAra(string term)
        {
            List<Kart> sonuc = new List<Kart>();
            sonuc.AddRange(TodoList.Where(t => t.Baslik.ToLower() == term).ToList());
            sonuc.AddRange(InProgressList.Where(t => t.Baslik.ToLower() == term).ToList());
            sonuc.AddRange(DoneList.Where(t => t.Baslik.ToLower() == term).ToList());
            return sonuc;
        }


        public void KartListele(string line, List<Kart> kartListe)
        {
            foreach (var item in kartListe)
            {
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine(" **************************************");
                Console.WriteLine($" Başlık      : {item.Baslik}");
                Console.WriteLine($" İçerik      : {item.Icerik}");
                Console.WriteLine($" Atanan Kişi : {item.AtananKisi.AdSoyad}");
                Console.WriteLine($" Büyüklük    : {item.Buyukluk}");
                Console.WriteLine($" Line        : {line}");
            }
        }
        #endregion
    }
}