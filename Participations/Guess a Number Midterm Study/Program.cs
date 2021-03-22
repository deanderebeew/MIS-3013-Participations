using System;

namespace Guess_a_Number_Midterm_Study
{
    class Program
    {
        static void Main(string[] args)
        {


            //int max;
            //int min;

            //Console.WriteLine("What is your Maxmimum Value? >>");
            //max = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("What is your Minimum value? >>");
            //min = Convert.ToInt32(Console.ReadLine());

            //Random rand = new Random();
            //int randomNbr = rand.Next(min, max);

            //int UserGuess;




            //do
            //{
            //    do
            //    {
            //        Console.WriteLine($"Guess the random number between {min} and {max} >>");

            //    } while (Int32.TryParse(Console.ReadLine(), out UserGuess) == false);

            //} while (UserGuess != randomNbr);

            //Console.WriteLine("Congratulations, that is the right number!");

            //Console.WriteLine("Define a minimum value");
            //string minimum = Console.ReadLine();
            //int min = Convert.ToInt32(minimum);

            //Console.WriteLine("Define a maximum value");
            //string maximum = Console.ReadLine();
            //int max = Convert.ToInt32(maximum);

            //Console.WriteLine($"enter things");
            //string guess = Console.ReadLine();
            //int userGuess = Convert.ToInt32(guess);

            //Random rand = new Random();
            //int randomnbr = rand.Next(min, max);
            //int random = Convert.ToInt32(randomnbr);

            //while (userGuess == random)
            //{
            //    Console.WriteLine("sorry wrong try again");
            //    guess = Console.ReadLine();
            //}

            //Console.WriteLine("correct");





            //int userguess;

            //do
            //{
            //    do
            //    {
            //        Console.WriteLine($"Guess the random number between {min} and {max} >>");
            //        string userguessstring = Console.ReadLine();
            //        userguess = Convert.ToInt32(userguessstring);

            //    } while (Int32.TryParse(Console.ReadLine(), out userguess) == false);

            //} while (userguess != randomnbr);

            //Console.WriteLine("Congratulations, that is the right number!");



            //Console.ReadKey();



            

            Console.WriteLine("What would you like your minimum value to be?");
            string minstring = Console.ReadLine();
            int min = Convert.ToInt32(minstring);

            Console.WriteLine("What would you like your maximum value to be?");
            string maxstring = Console.ReadLine();
            int max = Convert.ToInt32(maxstring);

            Random rand = new Random();
            int random = rand.Next(min, max);
            string randomNBR = Convert.ToString(random);

            int userguess = 0;

            do
            {

                do
                {
                    Console.WriteLine($"Guess a random number between {min} and {max}");


                } while (int.TryParse(Console.ReadLine(), out userguess)==false);


            } while (userguess != random);

            Console.WriteLine("That is correct!");

            Console.ReadLine();








        }
    }
}
