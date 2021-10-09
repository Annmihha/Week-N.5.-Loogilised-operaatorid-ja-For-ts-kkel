using System;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis puuvilja kasutaja sööb;

            // 1.variant, kasutaja valib numbri:
            //näide: string[] fruit = new string[5];

            string[] fruit = new string[5] { "an apple", "a banana", "a lemon", "an orange", "some grapes" };

            // näide kuidas programm kirjutab: Console.WriteLine(fruit[0]);
            // näide: Console.WriteLine(fruit[1]);
            // näide: jne...

            // Console.WriteLine("enter a number from 0 to 4:");
            // int userNumber = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine($"Today you will have {fruit[userNumber]}");

            // 2.variant, programm valib ise/ennustab puuvilja:
            Random rnd = new Random();
            int userNumber = rnd.Next(0, fruit.Length);

            Console.WriteLine($"Today you will have {fruit[userNumber]}.");


        }
    }
}
