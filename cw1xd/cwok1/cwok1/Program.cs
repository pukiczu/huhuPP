using System;

namespace cwok1
{
    class Program
    {
        static void Main(string[] args)
        {
            Punk punkt1 = new Punk();
            punkt1.x = 100;
            punkt1.y = 200;
            Console.WriteLine("punkt.x = " + punkt1.x);
            Console.WriteLine("punkt.y = " + punkt1.y);
            //wywolanie metody z kalsy 
            punkt1.WyswietlWspolrzedne();
            //zatrzymuje konsole


            //-------------------------------------//
            int wspX = punkt1.PobierzX();
            Console.WriteLine("wspolrzedna x =" + wspX);
            //albo bez deklaracji wspY
            //int wspY = punkt1.PobierzY();
            Console.WriteLine("wspolrzedna y =" + punkt1.PobierzY());






            System.Console.ReadKey();



        }
    }
}