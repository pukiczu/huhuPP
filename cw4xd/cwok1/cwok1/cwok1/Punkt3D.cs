using System;
using System.Collections.Generic;
using System.Text;

namespace cwok1
{
    class Punkt3D:Punkt2D
    {
        public int z;

        public Punkt3D():base()
        {
            //x = 1;
           // y = 1;
            z = 1;
        }
        public Punkt3D(int wspX, int wspY, int wspZ):base(wspX,wspY)
        {
           // x = wspX;
           // y = wspY;
            z = wspZ;
        }

        public  Punkt3D(Punkt3D punkt):base(punkt)
        {
            //x = punkt.x;
           // y = punkt.y;
            z = punkt.z;
        }
        

    }
}
