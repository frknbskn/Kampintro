using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string sentence = "My name is Furkan BAŞKAN";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Eymen BAŞKAN"; //sentence değeri değişir ama result2'de ilk değer görünür.
            Console.WriteLine(result2);

            bool result3 = sentence.EndsWith("ğ"); //bitiyorsa
            bool result4 = sentence.StartsWith("My name"); //başlıyorsa
            var result5 = sentence.IndexOf("name"); //belirli bir ifadeyi aramak için kullanılır. İLK BULDUĞU İFADEDEN SONRA ARAMAZ.
            var result6 = sentence.LastIndexOf(" "); //sondan başlıyor aramaya
            var result7 = sentence.Insert(0, "Hello! "); //Hello! My name is Eymen BAŞKAN
            Console.WriteLine(result7);
            var result8 = sentence.Substring(3); // name is Eymen BAŞKAN
            var result9 = sentence.Substring(3,4); // name
            var result10 = sentence.ToLower(); // bütün karakterleri küçük harf yapar.
            var result11 = sentence.ToUpper(); // bütük karakterleri büyük harf yapar.
            var result12 = sentence.Replace(" ","-"); // My-name-is-Eymen BAŞKAN 
            var result13 = sentence.Remove(2); //My   2. harften sonrasını remove
            var result14 = sentence.Remove(3, 4); // 3.harften itibaren 4 harf sil.
            Console.WriteLine(result14);



        }
    }
}
