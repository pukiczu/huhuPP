using System;

namespace cwok
{
    class Program
    {
        static void Main(string[] args)
        {
            Punk punkt1 = new Punk();
            Punk punkt2;
            
            punkt1.x = 100;
            punkt2.x = 200;
            Console.WriteLine("punkt1.x= {0}", punkt1.x);
            Console.WriteLine("punkt1.y= {0}", punkt1.y);

            Console.WriteLine("punkt2.x= {0}", punkt2.x);

            Console.ReadKey();

        }
    }
}
