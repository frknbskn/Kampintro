using System;

namespace switcha
{
    class Program
{
    static void Main(string[] args)
    {
        int i=5;
        switch (i)
        {
            case 1:
                    Console.WriteLine("1. durum");
                break;
            case 2:
                    Console.WriteLine("2.durum");
                break;
            case 3:
                    Console.WriteLine("3.durum");
                break;

            case 4:
                    Console.WriteLine("4.durum");
                break;

            default:
                Console.WriteLine("Durum yok.");

                break;
        }
    }
}
}
