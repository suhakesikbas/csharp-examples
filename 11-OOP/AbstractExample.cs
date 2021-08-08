using System;

namespace _11_OOP.Abstract
{
    public static class AbstractExmple
    {
        public static void Init()
        {
            Civic civic = new Civic();
            Console.WriteLine("****************************");
            Console.WriteLine("Araç Markası : {0}", civic.HangiMarkaArac());
            Console.WriteLine("Araç Model   : {0}", civic.GetType().Name);
            Console.WriteLine("Araç Rengi   : {0}", civic.StandartRengiNe());
            Console.WriteLine("Kapı Sayısı  : {0}", civic.KacTekerlektenOlusur());

            Corolla corolla = new Corolla();
            Console.WriteLine("****************************");
            Console.WriteLine("Araç Markası : {0}", corolla.HangiMarkaArac());
            Console.WriteLine("Araç Model   : {0}", corolla.GetType().Name);
            Console.WriteLine("Araç Rengi   : {0}", corolla.StandartRengiNe());
            Console.WriteLine("Kapı Sayısı  : {0}", corolla.KacTekerlektenOlusur());

            Focus focus = new Focus();
            Console.WriteLine("****************************");
            Console.WriteLine("Araç Markası : {0}", focus.HangiMarkaArac());
            Console.WriteLine("Araç Model   : {0}", focus.GetType().Name);
            Console.WriteLine("Araç Rengi   : {0}", focus.StandartRengiNe());
            Console.WriteLine("Kapı Sayısı  : {0}", focus.KacTekerlektenOlusur());
        }
    }

    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public abstract Marka HangiMarkaArac();
        public virtual Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }

    public class Civic : Otomobil
    {
        public override Marka HangiMarkaArac()
        {
            return Marka.Honda;
        }
    }
    public class Corolla : Otomobil
    {
        public override Marka HangiMarkaArac()
        {
            return Marka.Toyota;
        }
        public override Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
    public class Focus : Otomobil
    {
        public override Marka HangiMarkaArac()
        {
            return Marka.Ford;
        }
    }



    public enum Marka
    {
        Ford,
        Toyota,
        Honda
    }
    public enum Renk
    {
        Beyaz,
        Gri,
        Mavi
    }

}