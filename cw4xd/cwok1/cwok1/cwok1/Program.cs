using System;

namespace cwok1
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt3D punkt = new Punkt3D();
            Console.WriteLine("x=" + punkt.x);
            Console.WriteLine("y=" + punkt.y);
            Console.WriteLine("z=" + punkt.z);
            Console.WriteLine("\n");

            punkt.UstawX(50);
            punkt.UstawY(250);

            Console.WriteLine("x=" + punkt.x);
            Console.WriteLine("y=" + punkt.y);
            Console.WriteLine("z=" + punkt.z);
            Console.WriteLine("\n");

            punkt.UstawXY(5,5);

            Console.WriteLine("x=" + punkt.x);
            Console.WriteLine("y=" + punkt.y);
            Console.WriteLine("z=" + punkt.z);
            Console.WriteLine("\n");

            Punkt3D punkt2 = new Punkt3D(5,6,7);
            Console.WriteLine("x=" + punkt2.x);
            Console.WriteLine("y=" + punkt2.y);
            Console.WriteLine("x=" + punkt2.z);

            Console.ReadKey();
        }
    }
}
