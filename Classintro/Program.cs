using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Furkan";
            int yas = 26;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Furkan BAŞKAN";
            kurs1.izlenmeOrani = 69;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.izlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Nesli";
            kurs3.izlenmeOrani = 81;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Gizem";
            kurs4.izlenmeOrani = 99;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : "+kurs.Egitmen);

            }



           // Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int izlenmeOrani { get; set; }

        
    }
}
