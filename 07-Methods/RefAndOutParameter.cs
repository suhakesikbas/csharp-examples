using System;

namespace _07_Methods
{
    public static class RefAndOutParameter
    {
        public static void Example()
        {
            int a = 5, b = 8;
            Console.WriteLine(Topla(a, b));

            Topla(ref a,ref b);
            Console.WriteLine("a={0}; b={1};",a,b);

            Topla(a, b, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

        }

        static int Topla(int a, int b) => a + b;
        static int Topla(int a, int b, out int toplam) => toplam = a + b;
        static int Topla(ref int a, ref int b) => ++a + ++b;
    }
}
