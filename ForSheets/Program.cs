using System;

namespace ForSheets
{
    class Program
    {
        static void Main(string[] args)
        {
            //FOR
            for (int i = 0; i <= 100; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("it ended.");


            //WHİLE
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);

            //DO - WHİLE
            int number1 = 10;
            //do
            {
                Console.WriteLine(number);
                number1--;
            } while (number1 >= 0) ;

            string[] students = new string[3] { "Furkan", "Eymen", "Enes" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
