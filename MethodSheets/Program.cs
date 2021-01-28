using System;

namespace MethodSheets
{
    class Program
    {
        static void Main(string[] args)
        {
            Hesapla(1, 2);
            var result = Hesapla(3, 4);
            Console.WriteLine(result);

        }
        static int Hesapla(int sayi1,int sayi2=30)  // sayi 2 verilmezse def değeri=30 demektir.
        {
            
            Console.WriteLine("{0} ile {1} Toplandı.",sayi1,sayi2);
            return sayi1+sayi2;
        }
    }
}
