using System;

namespace ArraySheets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[4];
            students[0] = "Furkan";
            students[1] = "Eymen";
            students[2] = "Enes";
            students[3] = "Jack";

            string[] students2 = new[] { "Furkan", "Eymen", "Enes", "Jack" };

            string[] students3 = { "Furkan", "Eymen", "Enes", "Jack" };



            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
            foreach (var student in students3)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit" ,"Tekirdağ" },
                {"Ankara","Kırşehir" ,"Konya" },
                {"Antalya","Adana" ,"Mersin" },
                {"Trabzon","Sakarya" ,"Düzce" },
                {"İzmir","Muğla" ,"Manisa" },

            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("---------------");
            }

            
        }
    }
}
