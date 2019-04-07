using System;


namespace gogo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Grafika2D.Punkt punkt1 = new Grafika2D.Punkt();
            

            punkt1.x = 50;
            punkt1.y = 250;
            Console.WriteLine("G2D punkt1.x =" + punkt1.x);
            Console.WriteLine("G2D punkt1.y =" + punkt1.y);


            Grafika3D.Punkt punkt2 = new Grafika3D.Punkt();

            punkt2.x = 20;
            punkt2.y = 20;
            Console.WriteLine("G3D punkt1.x =" + punkt2.x);
            Console.WriteLine("G3D punkt1.y =" + punkt2.y);

            System.Console.ReadKey();
        }
    }
}
