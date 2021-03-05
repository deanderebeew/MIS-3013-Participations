using System;

namespace Collections_In_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            String message = "Taylor Swift, the Weeknd, Travis Scott";

            string msg2 = "tAylOr SwiFt";

            //output the contents of msg2 vertically instead of horizontally (each character on a new line)

            //for (int i = 0; i < msg2.Length; i++)
            //{
            //    Console.WriteLine(msg2[i]);
            //}


            //int indexOfSpace = msg2.IndexOf(' ');
            //msg2 = msg2.ToUpper()[0] + msg2.ToLower().Substring(1, indexOfSpace)
            //    + msg2.ToUpper()[indexOfSpace+1] + msg2.ToLower().Substring(indexOfSpace + 2);

            //Console.WriteLine(msg2);
            //return;

            //string msg2 = message.ToLower();
            //string msg3 = msg2.Substring(1);


            string newMessage = message.ToUpper()[0] + message.ToLower().Substring(1);

            string[] artists = message.Split(','); //array of strings, string is an array of characters, 

            for (int i = 0; i < artists.Length; i++)
            {
                string artist = artists[i].Trim();

                int indexOfSpace = artist.IndexOf(' ');
                msg2 = artist.ToUpper()[0] + artist.ToLower().Substring(1, indexOfSpace)
              + artist.ToUpper()[indexOfSpace + 1] + artist.ToLower().Substring(indexOfSpace + 2);

                Console.WriteLine(msg2);
                return;

                string[] names = artist.Split(' ');
                string firstName = names[0];
                string lastName = names[1];

                string newArtist = firstName.ToUpper()[0] + firstName.ToLower().Substring(1) + " " +
                    lastName.ToUpper()[0] + lastName.ToLower().Substring(1);
                Console.WriteLine(newArtist.Trim());
            }


            Console.WriteLine(newMessage);
        }
    }
}
