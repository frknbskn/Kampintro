using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> plakalar = new Dictionary<int, string>();
            plakalar.Add(01, "Adana");
            plakalar.Add(02, "Adıyaman");
            plakalar.Add(03, "Afyon");
            plakalar.Add(04, "Ağrı");
            plakalar.Add(05, "Amasya");
            plakalar.Add(54, "Sakarya");
            plakalar.Add(81, "Düzce");
            plakalar.Add(82, "Kozluk");

            

            Console.Write("Plakayı Yazınız:");
            int No=int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(plakalar[No]);
            }
            catch 
            {
                Console.WriteLine("Böyle bir plaka bulunmamaktadır.");
                
            }
        }
    }
}
