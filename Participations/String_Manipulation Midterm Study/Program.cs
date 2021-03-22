using System;

namespace String_Manipulation_Midterm_Study
{
    class Program
    {

        static string sentence = "Programming today is a race between software engineers striving to build" +
               "bigger and better idiot-proof programs, and the universe trying to build bigger and " +
               "better idiots. So far, the universe is winning.";
        static void Main(string[] args)
        {
            //Console.WriteLine($"{sentence}");
            //Console.WriteLine("Please pick a word in the above sentence");
            //string word = Console.ReadLine();

                //if (sentence.Contains(word) == true)
                //{
                //    Console.WriteLine("What would you like to change your word to?");
                //    string replaceword = Console.ReadLine();
                //}

            //else
            //{
            //    Console.WriteLine("Sorry I could not find your word");
            //    string reverse = string.Empty;

            //    for (int i = word.Length - 1; i >= 0; i++)
            //    {
            //        reverse = reverse + word[i];
            //    }

            //    Console.WriteLine(reverse);



                Console.WriteLine(sentence);
            Console.WriteLine("What word would you like to replace in the above sentence?");
            string sentencereplace = Console.ReadLine();



            if (sentence.Contains(sentencereplace) == true)
            {

                Console.WriteLine("What word would you like to replace it with?");
                string replacedword = Console.ReadLine();
            }

            else
            {
                Console.WriteLine("i can't find your word nerd");
                string reverse = string.Empty;


                for (int i = sentencereplace.Length - 1; i >= 0; i++)
                {
                    reverse = reverse + sentencereplace[i];
                }

                Console.WriteLine(reverse);
            }

           
           
            
           







            
        }
    }
}
