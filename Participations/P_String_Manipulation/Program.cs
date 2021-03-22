using System;

namespace P_String_Manipulation
{
    class Program
    {
        static string sentence = "Programming today is a race between software engineers striving to build" +
               "bigger and better idiot-proof programs, and the universe trying to build bigger and " +
               "better idiots. So far, the universe is winning.";
        static void Main(string[] args)
        {
            //1969

            //bool contains = false;

            //string msg = "Programming today is a race between software engineers striving to build" +
            //    "bigger and better idiot-proof programs, and the universe trying to build bigger and " +
            //    "better idiots. So far, the universe is winning.";


            //Console.WriteLine($"{msg}");
            //Console.WriteLine(" ");
            //string[] split = msg.Split(' ');



            //Console.WriteLine("What word would you like to change in the above sentence? >>");
            //string responseUser = Console.ReadLine();
            //string response = responseUser.ToLower();



            //Console.WriteLine($"What word would you like to change {response} to? >>");
            //string messageswitch = Console.ReadLine();

            ////if the message contains their response then it will replace the word with what they want


            //if (msg.Contains(response))
            //  {

            //    msg = msg.Replace(response, messageswitch);

            //    Console.WriteLine($"Your new message is: { msg.Replace(response, messageswitch)}");


            //}
            //else //If the message does not contain their response then it will reverse their word
            //{

            //    classValue.Contains()


            //    //string[] split = convert.response.ToCharArray();
            //    //Console.WriteLine($"Sorry! I couldn't find your word { response.reverse }");


            Console.WriteLine($"{sentence}");

            Console.WriteLine("Please pick a word in the above sentence");
            string response = Console.ReadLine();

            if (sentence.Contains(response) == true)
            {
                Console.WriteLine("What would you liek to replace this word with");
                string replaceword = Console.ReadLine();

                sentence = sentence.Replace(response, replaceword);
                Console.WriteLine($"{sentence}");
            }
            else
            {
                Console.WriteLine($"Sorry, could not find your word {response}");

                string reverse = string.Empty;
                for (int i = response.Length-1; i >= 0; i++)
                {
                    reverse = reverse + response[i];
                }
                Console.WriteLine(reverse);
            }



        }
    }
}
