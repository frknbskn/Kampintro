using System;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz.");
            int sayi = Int32.Parse(Console.ReadLine());
            if (AsalSayiMi(sayi))
            {
                Console.WriteLine("{0} is a prime number.",sayi);
            }
            else
            {
                Console.WriteLine("{0} is a not prime number.",sayi);
            }
        }

        private static bool AsalSayiMi(int number1)
        {
            bool result = true;
            for (int i = 2; i < number1-1; i++)
            {
                if(number1%i==0)
                {
                    result = false;
                    i = number1;
                }
            }
            return result;
        }
    }
}
