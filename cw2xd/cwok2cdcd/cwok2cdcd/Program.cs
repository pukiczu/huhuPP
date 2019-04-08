using System;

namespace cwok2cdcd
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int liczba1 = 100, liczba2;
            Program pg = new Program();

            pg.Zwieksz1(liczba1);
            Console.WriteLine("Po wywolaniu Zwieksz1(liczba1): ");
            Console.WriteLine(liczba1);

            pg.Zwieksz2(ref liczba1);
            Console.WriteLine("Po wywolaniu Zwieksz2(ref liczba1): ");
            Console.WriteLine(liczba1);

            pg.Zwieksz3(out liczba1);
            Console.WriteLine("Po wywolaniu Zwieksz3(out liczba1): ");
            Console.WriteLine(liczba1);

            pg.Zwieksz3(out liczba2);
            Console.WriteLine("Po wywolaniu Zwieksz3(out liczba2): ");
            Console.WriteLine(liczba2);

            System.Console.ReadKey();
        }
        public void Zwieksz1(int arg)
        {
            arg++;
        }
        public void Zwieksz2(ref int arg)
        {
            arg++;
        }
        public void Zwieksz3(out int arg)
        {
            arg = 10;
            arg++;
        }


        

        
    }
}
