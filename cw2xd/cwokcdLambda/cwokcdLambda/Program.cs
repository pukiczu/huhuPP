using System;

namespace cwokcdLambda
{
    class Program
    {
        //Wyrazienie Lambda -> przydatne puzniej 

        public Double Dodaj(Double arg1, Double arg2) => arg1 + arg2;
        static void Main(string[] args)
        {
            int liczba1 = 100, liczba2 = 200;
            Program pg = new Program();
            Double wynik = pg.Dodaj(liczba1, liczba2);
            Console.WriteLine($"wynik= {wynik}");

            System.Console.ReadKey();
        }
    }
}
