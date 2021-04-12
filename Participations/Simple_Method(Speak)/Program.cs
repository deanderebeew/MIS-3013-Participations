    using System;

namespace Simple_Method_Speak_
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("What is your favorite animal? >>");
            string animalanswer = Console.ReadLine();

            string animalsound = Speak(animalanswer);

            Console.WriteLine($"Your favorite animal, {animalanswer}, makes a {animalsound} sound!");
        }

        static string Speak(string animalname)
        {
            string sound;
            animalname = animalname.ToLower();

            if (animalname == "dog")
            {
                sound = "Woof";
            }
            else if (animalname == "monkey")
            {
                sound = "HooHooHaHa";
            }
            else if (animalname == "cat")
            {
                sound = "Meow";
            }
            else if (animalname == "cow")
            {
                sound = "Moo";
            }
            else if( animalname == "parrot")
            {
                sound = "Polly want a cracker";

            }
            else
            {
                sound = "WoogaBoogaDoogaMooga";    
            }



            return sound;



        }

        



        
    }
}
