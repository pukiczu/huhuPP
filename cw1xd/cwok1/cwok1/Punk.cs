using System;
using System.Collections.Generic;
using System.Text;

namespace cwok1
{
    class Punk
    {
        //Public zeby void main mogl to wziasc 
        public int x;
        public int y;






        //jestli chce otpalic to w main musi byc public && jest to metoda (chyba...proceduralna bo nie przyjmuje argumentow)
        public void WyswietlWspolrzedne()
        {
            Console.WriteLine("WYSWSP wspolrzenda x = " + x);
            Console.WriteLine("WYSWSP wspolrzenda y = " + y);
        }

        //medoty ktore zwracaja x
        public int PobierzX()
        {
            return x;
        }
        public int PobierzY()
        {
            return y;
        }
    }
}
