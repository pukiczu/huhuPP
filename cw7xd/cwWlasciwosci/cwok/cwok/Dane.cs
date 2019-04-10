using System;
using System.Collections.Generic;
using System.Text;

namespace cwok
{
    class Dane
    {
        //tylko odczyt
        private string _nazwa = "Klasa Dane";
        public string nazwa
        {
            get { return _nazwa; }
        }
        //tylko zapis
        private string _zapisDane="";
        public string zapisDane
        {
            set { _zapisDane = value; }
        }
        

        


        
    }
}
