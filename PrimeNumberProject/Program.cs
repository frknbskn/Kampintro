using System;

namespace PrimeNumberProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz:");
            int sayi = Int32.Parse(Console.ReadLine());
            if (AsalSayi(sayi))
            {
                Console.WriteLine(sayi+" is a prime number.");
            }
            else
            {
                Console.WriteLine(sayi+" is not a prime number.");
            }
        }
        private static bool AsalSayi(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
    }
}
