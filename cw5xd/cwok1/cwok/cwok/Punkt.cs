using System;
using System.Collections.Generic;
using System.Text;

namespace cwok
{
    public class Punkt
    {
        public Punkt()
        {
            int x = 3;
            int y = 3;
        }
        private double sinusalfa;
        private double r;
        //int bo funkcja ma zrwocic inta... // 2 kom w ciele //analogniczeni PobierzX()
        public int PobierzY()
        {
            double y = r * sinusalfa;
            //konwercja wyniku na int
            // to jest nie poprawne(utnie czesc ulamkowa ) 
            //JEST TO takzwane RZUTOWANIE TYPU
            return (int) y;
        }

        public int PobierzX()
        {
            double x = r * Math.Sqrt(1 - sinusalfa * sinusalfa);
            return (int) x;
        }

        public void UstawX(int wspX)
        {
            int x = wspX;
            int y = PobierzY();

            r = Math.Sqrt(x * x + y * y);
            sinusalfa = y / r;
        }
        public void UstawY(int wspY)
        {
            int x = PobierzX();
            int y = wspY;

            r = Math.Sqrt(x * x + y * y);
            sinusalfa = y / r;
        }

        

    }
}
