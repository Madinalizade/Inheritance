using System;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Insan insan = new Insan();
            insan.Id = 1;
            insan.Ad = "Madina";
            insan.Soyad = "Alizade";
            insan.Yas = 17;
            insan.YasayisYeri = "Sumqayit";
            Madina insan1 = new Madina();
            insan1.Uni = "Adnsu";
            insan1.SorgulamaQabiliyyeti = true;
            insan1.MotivasiyaMenbeyi = "TED";
            insan1.InsanTipi = "Dengesiz";
        }
    }
}
