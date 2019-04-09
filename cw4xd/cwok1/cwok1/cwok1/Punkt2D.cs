using System;
using System.Collections.Generic;
using System.Text;

namespace cwok1
{
    class Punkt2D
    {
        public int x;
        public int y;

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

        public void UstawXY(int wspX , int wspY)
        {
            x = wspX;
            y = wspY;
        }

        public void StrWsp()
        {
            Console.WriteLine("Wsp x=" + x);
            Console.WriteLine("Wsp y=" + y);
        }
        public Punkt2D()
        {
            x = 1;
            y = 1;
        }

        public Punkt2D(int wspX, int wspY)
        {
            x = wspX;
            y = wspY;
        }
        public Punkt2D(Punkt2D punkt) 
        {
            x = punkt.x;
            y = punkt.y;
            
        }
    }
}
