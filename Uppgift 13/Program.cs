using System;
namespace Uppgift_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in en lön");
            double lön1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in en lön till");
            double lön2 = double.Parse(Console.ReadLine());
            Console.WriteLine("skriv in en sista lön");
            double lön3 = double.Parse(Console.ReadLine());
            double medelvärde = (lön1 + lön2 + lön3) / 3;
            Console.WriteLine("Medelvärdet av " + lön1 + " och " + lön2 + " och " + lön3 + " är " + medelvärde + " kr ");
        }
    }
}