using System;

namespace FirsOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutajal sisestada oma ees- ja perekonnanimed;
            // programm kontrollib andmete pikkust;
            // programm kuvab kumb nendest on pikem

            Console.WriteLine("Palun sisesta oma eesnimi.");
            string firstName = Console.ReadLine();

            int firstNameLenght = firstName.Length;
            
            Console.WriteLine("Palun sisesta oma perekonnanimi.");
            string lastName = Console.ReadLine();
            int lastNameLenght = lastName.Length;

            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem perekonna nimest");
            }
            else 
            {
                Console.WriteLine("Sinu perekonnanimi on pikem eesnimest.");
            }
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} ja perekonnanimes on {lastName.Length} sümbolit");
        }
    }
}
