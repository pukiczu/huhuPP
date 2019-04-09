using System;

namespace cwokThis
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt punkt1 = new Punkt(3, 4);
            Punkt punkt2 = new Punkt();

            Console.WriteLine("punkt1x= " + punkt1.x);
            Console.WriteLine("punkt1y= " + punkt1.y);
            Console.WriteLine("\n ");

            Console.WriteLine("punkt2x= " + punkt2.x);
            Console.WriteLine("punkt2y= " + punkt2.y);
            Console.WriteLine("\n ");

            System.Console.ReadKey();
        }
    }
}
