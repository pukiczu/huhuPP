using System;
using System.Collections.Generic;
using System.Text;

namespace cwokThis
{
    class Punkt
    {
        public int x=200;
        public int y=100;

        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Punkt() : this(1, 1) { }
    }
}
