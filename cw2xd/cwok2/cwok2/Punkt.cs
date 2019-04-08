using System;
using System.Collections.Generic;
using System.Text;

namespace cwok2
{
    class Punkt
    {
        int x;
        int y; 

        public int PobierzX()
        {
            return x;
        }
        public int PobierzY()
        {
            return y;
        }
        public void UstawX(int wspX)
        {
            x = wspX;
        }
        public void UstawY(int wspY)
        {
            y = wspY;
        }

        public void UstawXY(Punkt punkt)
        {
            x = punkt.x;
            y = punkt.y;
        }
        public Punkt PobierzXY()
        {
            Punkt punkt = new Punkt();
            punkt.x = x;
            punkt.y = y;
            return punkt;

        }

        public void WyswietlWspolrzedne()
        {
            Console.WriteLine("wsprzedna x = " + x);
            Console.WriteLine("wsprzedna y = " + y);
        }
    }
}
