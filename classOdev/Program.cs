using System;
using System.Linq;


namespace classOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            urun urun1 = new urun();
            urun1.urunAdi = "Ayakkabı";
            urun1.gorsel = "fotografi";
            urun1.indirimsizFiyat = 450;
            urun1.indirimliFiyat=250;
            

            urun urun2 = new urun();
            urun2.urunAdi = "Tişört";
            urun2.gorsel = "fotoğrafı";
            urun2.indirimsizFiyat = 180;
            urun2.indirimliFiyat = 110;

            urun urun3 = new urun();
            urun3.urunAdi = "pantolon";
            urun3.gorsel = "fotoğrafı";
            urun3.indirimsizFiyat = 300;
            urun3.indirimliFiyat = 200;

            urun urun4 = new urun();
            urun4.urunAdi = "çanta";
            urun4.gorsel = "fotoğrafı";
            urun4.indirimsizFiyat = 300;
            urun4.indirimliFiyat = 400;

            urun urun5 = new urun("krampon", 350, 200, "fotoğrafı"); //karıştırıcıyla

            

            urun[] urunler = new urun[] { urun1, urun2, urun3, urun4 };

            



            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + " " + urun.gorsel + " indirimsiz fiyatı: " + urun.indirimsizFiyat + " indirimli fiyatı: " + urun.indirimliFiyat);


            }

            for (int i = 0; i < urunler.Length ; i++)
            {
                Console.WriteLine(urunler[i].urunAdi + " " + urunler[i].gorsel + " indirimsiz fiyatı: " + urunler[i].indirimsizFiyat + " indirimli fiyatı: " + urunler[i].indirimliFiyat);

            }

            int u = 0;

            while (u<urunler.Length)
            {
                Console.WriteLine(urunler[u].urunAdi + " " + urunler[u].gorsel + " indirimsiz fiyatı: " + urunler[u].indirimsizFiyat + " indirimli fiyatı: " + urunler[u].indirimliFiyat);
                u++;
            }


            int saat = 19;
            string zaman = (saat < 18) ? "ikindi" : "akşam" ;
            Console.WriteLine(zaman);




            Console.WriteLine("İsminizi Girin:");
            string isim=Console.ReadLine();
            Console.WriteLine("isminiz: " + isim);
            Console.WriteLine("Yaşınızı Girin:");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yaşınız: "+yas);

            int[] abc = { 5, 9, 1, 6 };
            Array.Sort(abc);
            Console.WriteLine(abc);
            Console.WriteLine(abc.Max());
            Console.WriteLine(abc.Min());
            Console.WriteLine(abc.Sum());






        }
    }
    class urun
    {
        public string urunAdi { get; set; }

        public int indirimsizFiyat { get; set; }

        public int indirimliFiyat { get; set; }

      
        public string gorsel { get; set; }

        public urun(string urunAdii, int indirimsizFiyatt, int indirimliFiyatt, string gorsell) //constructor
        {
            urunAdi = urunAdii;
            indirimsizFiyat = indirimsizFiyatt;
            indirimliFiyat = indirimliFiyatt;
            gorsel = gorsell;
        }

    }
}
