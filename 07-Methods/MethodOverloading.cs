using System;

namespace _07_Methods
{
    public static class MethodOverloading
    {
        public static void Example()
        {
            Metotlar metotlar = new Metotlar();
            metotlar.EkranaYazdir("Lorem ipsum dolar sit amet");
            int ifade = 999;
            metotlar.EkranaYazdir(ifade);
            metotlar.EkranaYazdir("Lorem","ipsum");

        }
    }
    class Metotlar
    {
        public void EkranaYazdir(string mesaj) => Console.WriteLine(mesaj);
        public void EkranaYazdir(int sayi) => Console.WriteLine(sayi);
        public void EkranaYazdir(string mesaj,string mesaj2) => Console.WriteLine(mesaj+" " +mesaj2);
        
    }
}
