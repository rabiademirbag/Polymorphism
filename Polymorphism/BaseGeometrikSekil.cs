using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class BaseGeometrikSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public virtual void AlanHesapla()
        {
            Console.WriteLine("Alan: " + Genislik * Yukseklik);;
        }
    }
    public class Kare:BaseGeometrikSekil
    {
        public override void AlanHesapla()
        {
            Console.WriteLine("Kare alan hesabı:" + Genislik * Yukseklik);
        }
    }
    public class Dikdortgen:BaseGeometrikSekil
    {
        public override void AlanHesapla()
        {
            Console.WriteLine("Dikdörtgen alan hesabı:" +Genislik*Yukseklik);
        }
    }
    public class DikUcgen:BaseGeometrikSekil
    {
        public override void AlanHesapla()
        {
            Console.WriteLine("Üçgen alan hesabı:" +Genislik * Yukseklik/ 2);
        }
    }
}
