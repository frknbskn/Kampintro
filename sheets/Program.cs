using System;

namespace sheets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminiz?");
            string name = Console.ReadLine();
            Console.WriteLine("Hoş geldin {0}!", name);
            Console.WriteLine("Bugün nasılsın " + name + "?");
            Console.WriteLine("Today is " + Days.Friday);


            int sayi = 10;
            if (sayi == 10)
            {
                Console.WriteLine("Sayı 10'dur.");

            }
            else
            {
                Console.WriteLine("Sayı 10 değildir.");

            }
            Console.WriteLine(sayi == 10 ? "Sayı 10'dur." : "Sayı 10 değildir.");
            string sayi1 = sayi == 10 ? "Sayı 10'dur." : "Sayi 10 değildir";
            Console.WriteLine(sayi1);

            //if (sayi == 10)
            //{
            //    Console.WriteLine("Sayi 10'dur.");
            //}
            //else if (number == 20)
            //{
            //    Console.WriteLine("sayi 20'dir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayımız 10 veya 20 değildir.");
            //}

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Sayi 10'dur");
            //        break;
            //    case 20:
            //        Console.WriteLine("Sayi 20'dir.");
            //    default:
            //        Console.WriteLine("Sayı 10 ya da 20 DEĞİLDİR.");
            //        break;
            //}
            var number = 50;
            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("number is between 0-100");
            //}
            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("number is between 100-200");
            //}
            //else if (number > 200 || number < 0)
            //{
            //    Console.WriteLine("number is less than 0 or greater than 200");
            //}

            



        }




        enum Days
        {
            Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
    }
}


