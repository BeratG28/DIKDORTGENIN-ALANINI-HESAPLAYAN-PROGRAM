using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, Alan;
            
            Console.Write("Uzun kenarın Ölçüsünü giriniz");
            a= Convert.ToInt16(Console.ReadLine());
            Console.Write("Kısa kenarın ölçüsünü giriniz");
            b= Convert.ToInt16(Console.ReadLine());
            Alan= a * b; 
            Console.Write(Alan);

            Console.Read();

        }
    }
}
