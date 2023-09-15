using System;
 namespace Uppgift2._2 
{
  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin?");
            string x = Console.ReadLine();
            Console.WriteLine("Hur långt hoppade Alma");
            string y = Console.ReadLine();
            double z = double.Parse(x);
            double g = double.Parse(y);
            double sum = z - g;
            Console.WriteLine("Elin hoppade " +sum +  " Längre");

        }
    }
}