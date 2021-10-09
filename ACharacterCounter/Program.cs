using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutajal sisestada oma ees- ja perekonnanimi;
            // programm kuvab, mitu 'a' tähte on ees- ja perekonnanimes kokku;

            Console.WriteLine("Loeme üle'a' tähed Sinu nimes! ");
            Console.WriteLine("Palun sisesta onma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Palun sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();

           // Console.WriteLine(fullName);
            int aCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    aCounter++;
                }

            }

            if (aCounter == 0)
            {
                Console.WriteLine("Sinu täisnimes pole ühegi 'a' tähte.");
            }
            else if (aCounter != 1)
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte.");
            }
            else 
            {
                Console.WriteLine($"Sinu nimes on {aCounter} 'a' täht.");
            }
        }
    }
}
