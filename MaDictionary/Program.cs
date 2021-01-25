using System;

namespace MaDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            dictionaryManager<int, string> selfDictionary = new dictionaryManager<int, string>();
            selfDictionary.Add(01, "Adana");
            selfDictionary.Add(54, "Sakarya");

            selfDictionary.GetAll();

            


            

            
        }

       
    }
}
