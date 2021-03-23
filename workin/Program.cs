using System;
using System.Collections.Generic;

namespace workin
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> plaka = new Dictionary<int, string>();
            plaka.Add(1, "Adana");
            plaka.Add(2, "Adıyama");
            plaka.Add(54, "Sakarya");
            plaka.Add(67, "Zonguldak");
            plaka.Add(81, "Düzce");
            Console.WriteLine("Plakayı giriniz");
            int no = int.Parse(Console.ReadLine());

            Console.WriteLine(plaka[no]);

            mydict<int, string> deneme = new mydict<int, string>();


        }
    }
}
