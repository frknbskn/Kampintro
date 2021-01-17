using System;

namespace myMethod
{
    class Program
    {
        static void MyMethod(string isim="Furkan")
        {
            Console.WriteLine(isim+" BAŞKAN");
        }






        static void Main(string[] args)
        {
            MyMethod("Nesli");
            MyMethod("Neslihan");
            MyMethod();


            Console.WriteLine(besiletopla(10));
            Console.WriteLine(toplama(10, 10));

            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            Car myObj2 = new Car();
            Console.WriteLine(myObj2.color);

            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "Black";
            Ford.year = 1969;

            Car opel = new Car();
            opel.model = "astra";
            opel.color = "red";
            opel.year = 2005;


            






        }

        static int besiletopla(int x)
        {
            return 5 + x;
        }

        static int toplama(int x, int y)
        {
            return x + y;

        }
    }
    class Car
    {
       public string color = "Red";
        string speed = 200;
        string model;
        string color;

        int year;




    }
}
