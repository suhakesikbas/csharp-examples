using System;

namespace _08_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp Hoşgeldiniz!.";
            string degisken2 = "dersimiz CSharp Hoşgeldiniz!.";
            string degisken3 = "CSharp";
            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(degisken, "Dersimiz CSharp");

            //Compare CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken3));
            Console.WriteLine(degisken.StartsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken.EndsWith("Dersimiz"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("JavaScript"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0, "Hoşgeldiniz"));

            //PadLeft PadRight
            Console.WriteLine(degisken + degisken3.PadLeft(50));
            Console.WriteLine(degisken + degisken3.PadLeft(50,'*'));
            Console.WriteLine(degisken + degisken3.PadRight(50));
            Console.WriteLine(degisken + degisken3.PadRight(50,'-'));

            //Remove
            Console.WriteLine(degisken.Remove(9,6));

            // Replace
            Console.WriteLine(degisken.Replace("CSharp","Java"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(0,9));

        }
    }
}
