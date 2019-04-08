using System;

namespace cwok2cd
{   //przeciazenie metody w klasie sa 2 metody o tej samej naziwie ale roznia sie argumentami 
    //dlatego mozna ich uzyc 
    class Program
    {
        static void Main(string[] args)
        {
            Punkt punkt1 = new Punkt();
            Punkt punkt2 = new Punkt();

            punkt1.ustawXY(100, 100);
            punkt2.ustawXY(10, 20);

            Console.WriteLine("pirwsze ustawienie wsp:");
            Console.WriteLine("x= " + punkt1.x);
            Console.WriteLine("y= " + punkt1.y);
            Console.WriteLine(" " );

            //to jest dziwne xd ;/ // 
            punkt1.ustawXY(punkt2);
            //---------------------///


            Console.WriteLine("drugim ustawienie wsp:");
            Console.WriteLine("x= " + punkt1.x);
            Console.WriteLine("y= " + punkt1.y);
            Console.WriteLine(" ");

            System.Console.ReadKey();

        }
    }
}
