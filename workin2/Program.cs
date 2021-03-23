using System;

namespace workin2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı Giriniz.");

            int sayi = Convert.ToInt32(Console.ReadLine());

            bool result = true;
            for (int i = 2; i < sayi-1; i++)
            {
                if (sayi%i==0)
                {
                    result = false;
                    i = sayi;
                }
            }
            if (result==true)
            {
                Console.WriteLine("Sayı asaldır.");
            }
            else
            {
                Console.WriteLine("Sayı asal değildir.");
            }
        }
    }
}
