using System;

namespace Coin_Flip_Midterm_Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomnumber = rand.Next(1, 3);

            string HeadsorTails = string.Empty;


            if (randomnumber == 1)
            {
                HeadsorTails = "Heads";
            }
            else
            {
                HeadsorTails = "Tails";
            }

            Console.WriteLine("Heads or tails?");
            string guess = Console.ReadLine();

            if (guess == HeadsorTails)
            {
                Console.WriteLine($"The coin landed on {HeadsorTails}, you were right!");
            }
            else if (guess != HeadsorTails)
            {
                Console.WriteLine($"The coin landed on {HeadsorTails}, you were wrong!");
            }

            Console.ReadKey();






        }
    }
}
