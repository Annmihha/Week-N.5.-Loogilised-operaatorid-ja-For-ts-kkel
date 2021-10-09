using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm ennustab, mis kasutajaga juhtub homme (kasutada Random klassi);

            string[] predictions = { "win a million", "fall in love", "buy youtube premium", "join the darkside for cookies" }; // massiiv

            Random rnd = new Random();
            int userNumber = rnd.Next(0, predictions.Length);

            Console.WriteLine($"Hello! Tomorrow you will {predictions[userNumber]}.");

        }
    }
}
