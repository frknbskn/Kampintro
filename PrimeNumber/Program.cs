using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());


            if (IsPrimeNumber(sayi))
            {
                Console.WriteLine("{0} is a prime number.",sayi);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number.",sayi);
            }
        }
        private static bool IsPrimeNumber(int number)
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
