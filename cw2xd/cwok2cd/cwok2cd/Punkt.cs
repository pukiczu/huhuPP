using System;
using System.Collections.Generic;
using System.Text;

namespace cwok2cd
{
    class Punkt
    {
        public int x;
        public int y;

        public void ustawXY(int wspX, int wspY)
        {
            x = wspX;
            y = wspY;
        }
        public void ustawXY(Punkt punkt)
        {
            x = punkt.x;
            y = punkt.y;
        }
    }
}
