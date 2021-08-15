using System;

namespace Proje_02.Models
{
    public class Kart
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public Kisi AtananKisi { get; set; }
        public Buyukluk Buyukluk { get; set; }
    }
}