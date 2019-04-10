using System;

namespace cwok
{
    class Program
    {
        static void Main(string[] args)
        {
            Kontener obj = new Kontener();
            obj.wartosc = 100;
            Console.WriteLine("Hello World!"+obj.wartosc);

            //----------------------------------------------------//

            Data pierwszaData = new Data();
            try
            {
                pierwszaData.DzienTygodnia = 8;
            }
            catch(ValueOutOfRangeException)
            {
                Console.WriteLine("Watrtosc poza zakresem");
            }
            Data drugaData = new Data();
            drugaData.DzienTygodnia = 2;

            Console.WriteLine("\n ^^^Po pierwszym przypisaniu^^^" );
            Console.Write("1.numer dnia tygodnia to");
            Console.WriteLine("{0}.", pierwszaData.DzienTygodnia);
            Console.Write("2.numer dnia tygodnia to");
            Console.WriteLine("{0}.", drugaData.DzienTygodnia);

            drugaData.DzienTygodnia = 9;
            Console.WriteLine("\n ^^^Po Drugim przypisaniu^^^");
            Console.Write("2.numer dnia tygodnia to");
            Console.WriteLine("{0}.", drugaData.DzienTygodnia);


            //------------------------------------------------//
            Dane dane1 = new Dane();
            string napis = dane1.nazwa;
            Console.WriteLine(napis);
            //------------------------------------------------//
            Dane zapisz = new Dane();
            zapisz.zapisDane = "Klasa do zapisu";
            Console.ReadKey();
        }
    }
}
