using Polymorphism;

public class Program
{
    public static void Main (string[] args)
    {
        Kare kare = new Kare{Genislik=2, Yukseklik=5};
        DikUcgen dikUcgen = new DikUcgen { Genislik = 2, Yukseklik = 5 };
        Dikdortgen dikdortgen = new Dikdortgen { Genislik = 2, Yukseklik = 5 };

        kare.AlanHesapla();
        dikUcgen.AlanHesapla();
        dikdortgen.AlanHesapla();
    } 
}