using System;

namespace _11_OOP
{
    public static class InterfaceExample
    {
        public static void Init()
        {

            Civic civic = new Civic();
            Console.WriteLine("****************************");
            Console.WriteLine("Araç Markası : {0}", civic.HangiMarkaArac());
            Console.WriteLine("Araç Model   : {0}", civic.GetType().Name);
            Console.WriteLine("Araç Rengi   : {0}", civic.StandartRengiNe());
            Console.WriteLine("Kapı Sayısı  : {0}", civic.KacKapi());

            Corolla corolla = new Corolla();
            Console.WriteLine("****************************");
            Console.WriteLine("Araç Markası : {0}", corolla.HangiMarkaArac());
            Console.WriteLine("Araç Model   : {0}", corolla.GetType().Name);
            Console.WriteLine("Araç Rengi   : {0}", corolla.StandartRengiNe());
            Console.WriteLine("Kapı Sayısı  : {0}", corolla.KacKapi());

            Focus focus = new Focus();
            Console.WriteLine("****************************");
            Console.WriteLine("Araç Markası : {0}", focus.HangiMarkaArac());
            Console.WriteLine("Araç Model   : {0}", focus.GetType().Name);
            Console.WriteLine("Araç Rengi   : {0}", focus.StandartRengiNe());
            Console.WriteLine("Kapı Sayısı  : {0}", focus.KacKapi());

        }

        public static void InitExample1()
        {

            DatabaseLogger dbLogger = new DatabaseLogger();
            dbLogger.WriteLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();

        }
    }
    #region  Interface Example 1

    public interface ILogger
    {
        void WriteLog();
    }

    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Dosyaya yazdım.");
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database'e yazdım.");
        }
    }

    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Sms olarak gönderildi.");
        }
    }

    public class LogManager : ILogger
    {
        public ILogger _logger;

        public LogManager(ILogger logger)
        {
            _logger = logger;
        }
        public void WriteLog()
        {
            _logger.WriteLog();
        }

    }

    #endregion

    #region Interface Example 2

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
    public interface IOtomobil
    {
        int KacKapi();
        Marka HangiMarkaArac();
        Renk StandartRengiNe();
    }

    public class Civic : IOtomobil
    {
        public int KacKapi()
        {
            return 4;
        }
        public Marka HangiMarkaArac()
        {
            return Marka.Honda;
        }
        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
    public class Corolla : IOtomobil
    {
        public int KacKapi()
        {
            return 4;
        }
        public Marka HangiMarkaArac()
        {
            return Marka.Toyota;
        }
        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
    public class Focus : IOtomobil
    {
        public int KacKapi()
        {
            return 2;
        }
        public Marka HangiMarkaArac()
        {
            return Marka.Ford;
        }
        public Renk StandartRengiNe()
        {
            return Renk.Mavi;
        }
    }


    #endregion
}