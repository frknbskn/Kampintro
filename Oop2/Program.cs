using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Furkan";
            //musteri1.Soyadi = "BAŞKAN";
            //musteri1.Id = 1;
            //musteri1.TcNo = "33333333";
            //musteri1.MusteriNo = "13645";
            //musteri1.SirketAdi = "?";


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Furkan";
            musteri1.Soyadi = "BAŞKAN";
            musteri1.TcNo = "35900000";
            

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54621";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12316541";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);



        }
    }
}
