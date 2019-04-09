using System;

namespace cwok1
{
    class Program
    {
        static void Main(string[] args)
        {
            //utwozenie obiektu klasy Punkt
            Punkt punkt1 = new Punkt();
            Console.WriteLine("punkt.x= " + punkt1.x);
            Console.WriteLine("punkt.y= " + punkt1.y);

            Console.WriteLine("\n" );
            //utwozenie obiektu klasy PunktWithArg trzeba podac argumenty
            PunktWithArg punkt2 = new PunktWithArg(10, 20);
            Console.WriteLine("punkt.x= " + punkt2.x);
            Console.WriteLine("punkt.y= " + punkt2.y);

            Console.WriteLine("\n");

            //punkt3 jako argument przyjmuje obiejkt punk1 dlatego wartosci sa jak w punkt1 xd .. 

            Punkt punkt3 = new Punkt(punkt1);
            Console.WriteLine("x= " + punkt3.x);
            Console.WriteLine("y= " + punkt3.y);

            System.Console.ReadKey();
        }
    }
}
