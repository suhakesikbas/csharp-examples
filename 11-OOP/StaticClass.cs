using System;

namespace _11_OOP
{
    public static class StaticClassAndFields
    {
        public static void Example()
        {
            Console.WriteLine("Toplam Personel  : {0}",Personel.PersonelSayisi);
            // Personel personel = new Personel("Hakan","Çalık","IK");
            // personel.PersonelBilgileriYazdir();

            // var toplam = Mat.Toplam(5,3);
            // Console.WriteLine(toplam.ToString());

            // var cikar = Mat.Cikar(10,2);
            // Console.WriteLine(toplam.ToString());
        }

    }

    class Personel
    {
        private static int personelSayisi;
        private string isim;

        private string soyisim;
        private string departman;

        public static int PersonelSayisi { get => personelSayisi; }
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Departman { get => departman; set => departman = value; }

        public Personel()
        {
            
        }

        static Personel()
        {
            personelSayisi = 0;
        }


        public Personel(string isim, string soyisim, string departman = null)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            personelSayisi++;
        }

        public void PersonelBilgileriYazdir(){
            Console.WriteLine("Personel Bilgileri");
            Console.WriteLine("Ad Soyad         : {0} {1}", Isim, Soyisim);
            Console.WriteLine("Departman        : {0}", Departman);
            Console.WriteLine("Toplam Personel  : {0}", PersonelSayisi);
        }
    }
    static class Mat{
        public static long Toplam(int sayi1, int sayi2){
            return sayi1 + sayi2;
        }
        public static long Cikar(int sayi1, int sayi2){
            return sayi1 - sayi2;
        }
    }
}