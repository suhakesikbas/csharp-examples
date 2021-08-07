using System;

namespace _11_OOP
{
    public static class Encapsulation
    {
        public static void Example()
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Serdar";
            ogrenci.Soyisim = "Karataş";
            ogrenci.Sinif=1;
            ogrenci.OgrenciNo = 119;

            ogrenci.OgrenciBilgileri();

            ogrenci.SinifDusur();
            ogrenci.OgrenciBilgileri();

            Ogrenci ogrenci2 = new Ogrenci("Selim","Şen",122,3);
            ogrenci2.OgrenciBilgileri();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { get => sinif; set{
            if (value>=1)
                sinif = value;
        } }

        public Ogrenci() { }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public void OgrenciBilgileri()
        {
            Console.WriteLine("Öğrenci Bilgileri");
            Console.WriteLine("Ad Soyad     : {0} {1}", this.Isim, this.Soyisim);
            Console.WriteLine("Öğrenci No   : {0}", this.OgrenciNo);
            Console.WriteLine("Sınıf        : {0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif += 1;
        }
        public void SinifDusur()
        {
           this.Sinif -= 1;
        }
    }
}