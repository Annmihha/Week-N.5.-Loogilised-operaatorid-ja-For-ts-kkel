using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutajal sisestada oma eesnimi;
            // programm kuvab kasutaja eesnime pikkuse sümbolite arvus;

            Console.WriteLine("Palun sisesta oma eesnimi.");
            string firstName = Console.ReadLine();

            //int firstNameLenght = firstName.Length;

            Console.WriteLine($"Sinu eesnime pikkus on {firstName.Length} sümbolit.");
        }
    }
}
