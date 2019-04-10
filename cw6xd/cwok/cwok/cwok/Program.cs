using System;

namespace cwok
{
    class Program
    {
        static void Main(string[] args)
        {
            

            A.print();
            //b.print();


            B Bint = new B();
            Bint.liczba = 10;
            ((A)Bint).liczba=20;

            Console.WriteLine("wartosc pola liczba z B:");
            Console.WriteLine(Bint.liczba);
            Console.WriteLine("wartosc pola liczba z B dziedziczonego po A:");
            Console.WriteLine(((A)Bint).liczba);


            Console.ReadKey();
        }
    }
}
