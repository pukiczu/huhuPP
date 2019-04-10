using System;
using System.Collections.Generic;
using System.Text;

namespace cwok
{
    public class Data
    {
        private byte _dzien;
        public byte DzienTygodnia
        {
            get { return _dzien; }
            set
            {
                if( value>0 && value < 8)
                {
                    _dzien = value;
                }
                else
                {
                    //throw new ValueOutOfRangeException();
                }
            }
        }

        

    }
}
