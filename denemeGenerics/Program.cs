using System;
using System.Collections.Generic;

namespace denemeGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri(1, "Furkan", "BAŞKAN", "Sakarya");
            Musteri musteri2 = new Musteri { Id = 2, FirstName = "Eymen", LastName = "BAŞKAN", City = "Zonguldak" };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.List();
            musteriManager.Remove(musteri2);


        }

    }
}
        

