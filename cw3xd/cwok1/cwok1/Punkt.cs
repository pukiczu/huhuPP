using System;
using System.Collections.Generic;
using System.Text;

namespace cwok1
{
     class Punkt
    {
        public int x;
        public int y;


        //***Konstruktor***///
        /// <summary>
        ///musi mniec ta sama nazwie co klasa , jest to specjalna metoda kotra jest wywolywana zawsze podczas twoznie obiektu czyli nie zostana przymisane nule tylko x=1iy=2;
        /// </summary>
        public Punkt()
        {
            x = 1;
            y = 2;
        }
        //Przeciazony konstrukotr ktory jako argument przyjmie obiekt klasy Punkt
        public Punkt(Punkt punkt)
        {
            x = punkt.x;
            y = punkt.y;
        }


    }
}
