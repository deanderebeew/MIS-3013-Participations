using System;

namespace Classes_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy toygun = new Toy();
            toygun.Manufacturer = "Hasbro";
            toygun.Name = "Nerf Gun";
            toygun.Price = 9.99;
            toygun.SetNotes("Actual gun");

            string NoteResponse1 = toygun.GetNotes();

                string aisle = toygun.GetAisle();
            Console.WriteLine(aisle);
            Console.WriteLine(NoteResponse1);


            Toy ball = new Toy();
            ball.Manufacturer = "Mattell";
            ball.Name = "Bouncy Bouncy Ball";
            ball.Price = 1.99;
            ball.SetNotes("Highest bouncing ball ever made");

            string NoteResponse2 = ball.GetNotes();

            string aisle2 = ball.GetAisle();
            Console.WriteLine(aisle2);
            Console.WriteLine(NoteResponse2);
        }
    }
}
