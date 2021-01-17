using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // do not repeat yourself. kendini tekrarlama.
            // değer tutucu, alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarinDunkuDegeri = 7.35;
            double dolarinBugunkuDegeri = 7.45;


            if (dolarinDunkuDegeri>dolarinBugunkuDegeri)
            {
                Console.WriteLine("Azalış Butonu Göster");
            }
            else if (dolarinDunkuDegeri<dolarinBugunkuDegeri)
            {
                Console.WriteLine("Artış Butonunu Göster");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }


            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
