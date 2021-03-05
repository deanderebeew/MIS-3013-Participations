using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int max;
            int min;

            Console.WriteLine("What is your Maxmimum Value? >>");
            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your Minimum value? >>");
            min = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            int randomNbr = rand.Next(min, max);

            int UserGuess;
            //Console.WriteLine($"Please guess a number between {min} and {max}!>>");
            //UserGuess = Convert.ToInt32(Console.ReadLine());



            do
            {
                do
                {
                    Console.WriteLine($"Guess the random number between {min} and {max} >>");

                } while (Int32.TryParse(Console.ReadLine(), out UserGuess) == false);

            } while (UserGuess != randomNbr);

            Console.WriteLine("Congratulations, that is the right number!");



            Console.ReadKey();


            //do
            //{
            //    if (UserGuess == randomNbr)
            //    {
            //        Console.WriteLine("That is the correct number!");
            //        UserGuess = Convert.ToInt32(Console.ReadLine());


            //    }
            //    else
            //    {
            //        Console.WriteLine("That number is incorrect, guess again!");
            //        UserGuess = Convert.ToInt32(Console.ReadLine());
            //    }

            //} while (randomNbr != UserGuess);



        }
    }
}
