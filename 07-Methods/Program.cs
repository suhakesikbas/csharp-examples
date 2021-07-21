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
        }

        static int Topla(int a, int b) => a + b;
    }

    class Metotlar
    {
        public void EkranaYazdir(string mesaj) => Console.WriteLine(mesaj);

        public int ToplaveArtir(ref int a,ref int b)=> ++a + ++b;
    }
}
