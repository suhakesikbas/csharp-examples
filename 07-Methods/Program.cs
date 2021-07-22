using System;

namespace _07_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =5, b =8;
            Console.WriteLine(Topla(a, b));

            Metotlar metotlar = new Metotlar();
            metotlar.EkranaYazdir("Lorem ipsum dolar sit amet");
            int sonuc = metotlar.ToplaveArtir(ref a,ref b);
            metotlar.EkranaYazdir(sonuc.ToString());
            metotlar.EkranaYazdir((a+b).ToString());

            //Out Parametreler
            string sayi = "999";
            bool sonuc2 = int.TryParse(sayi, out int result);
            if (sonuc2)
            {
                Console.WriteLine("Başarılı.");
                Console.WriteLine(result);
            }else{
                Console.WriteLine("Başarısız.");
            }

            Topla(a,b,out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            int ifade = 999;
            metotlar.EkranaYazdir(ifade);
            metotlar.EkranaYazdir("Lorem","ipsum");

        }

        static int Topla(int a, int b) => a + b;
        static int Topla(int a, int b, out int toplam) => toplam = a + b;
    }

    class Metotlar
    {
        public void EkranaYazdir(string mesaj) => Console.WriteLine(mesaj);
        public void EkranaYazdir(int sayi) => Console.WriteLine(sayi);
        public void EkranaYazdir(string mesaj,string mesaj2) => Console.WriteLine(mesaj+" " +mesaj2);

        public int ToplaveArtir(ref int a,ref int b)=> ++a + ++b;
        
    }
}
