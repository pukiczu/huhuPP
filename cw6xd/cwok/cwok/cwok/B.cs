using System;
using System.Collections.Generic;
using System.Text;

namespace cwok
{
    public class B : A
    {
        public new int liczba;

        public new void print()
        {
           
            Console.WriteLine("Metoda print z klasy B");
        }
    }
}
