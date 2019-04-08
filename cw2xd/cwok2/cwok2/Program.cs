using System;

namespace cwok2
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt pierwszyPunkt = new Punkt();
            Punkt drugiPunkt;

            pierwszyPunkt.UstawX(20);
            pierwszyPunkt.UstawY(30);

            Console.WriteLine("pierwszyPunkt:");
            pierwszyPunkt.WyswietlWspolrzedne();
            Console.WriteLine(" ");

            drugiPunkt = pierwszyPunkt.PobierzXY();

            Console.WriteLine("\n drugiPunkt:");
            drugiPunkt.WyswietlWspolrzedne();
            Console.WriteLine(" ");

            Punkt trzeciPunkt = new Punkt();
            trzeciPunkt.UstawXY(drugiPunkt);

            Console.WriteLine("\n trzeciPunkt:");
            trzeciPunkt.WyswietlWspolrzedne();
            Console.WriteLine(" ");

            System.Console.ReadKey();
        }
    }
}
