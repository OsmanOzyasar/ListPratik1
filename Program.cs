using System;

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> davetliler = new List<string>() {"Bülent Ersoy", "Ajda Pekkan", "Ebru Gündeş", "Hadise","Hande Yener", "Tarkan", "Funda Arar", "Demet Akalın"}; //DAVETLİLERİN OLDUĞU BİR STRİNG LİSTE OLUŞTURULMUŞTUR

            int number = 1;

            Console.WriteLine("**DAVETLİLER**");

            foreach (string s in davetliler) //foreach döngüsü ile hepsi ekrana yazdırılır
            {
                Console.WriteLine($"{number} - {s}");
                number++;
            }
        }
    }
}