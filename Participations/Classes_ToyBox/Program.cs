using System;
using System.Collections.Generic;

namespace Classes_ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToyBox> toyboxes = new List<ToyBox>();

            
            string response = string.Empty;
            do
            {

                Console.WriteLine("What is the location of your ToyBox");
                string location = Console.ReadLine();

                Console.WriteLine("Who is the owner of your ToyBox");
                string owner = Console.ReadLine();

                ToyBox tb1 = new ToyBox()
                {

                    Location = location,
                    Owner = owner

                };

                toyboxes.Add(tb1);

                Console.WriteLine("Do you want to start a new toybox");
                response = Console.ReadLine();

            } while (response.ToLower() == "yes");

            string answer = string.Empty;

            foreach (ToyBox toyBox in toyboxes)
            {

                do
                {

                    Console.WriteLine($"Time to fill {toyBox.Owner}'s Toy Box!");

                    Toy newToy = GetNewToyFromUser();
                    toyBox.Toys.Add(newToy);

                    Console.WriteLine("Do you want to enter another toy? yes or no");
                    answer = Console.ReadLine();

                } while (answer.ToLower() == "yes");
            }

                

            Console.WriteLine("Time to take a look at all your toys");

            foreach  (ToyBox toyBox in toyboxes)
            {

                Console.WriteLine($"Content of {toyBox.Owner}'s ToyBox!");

                foreach (Toy toy in toyBox.Toys)
                {
                    Console.WriteLine($"\n{toy.Name} was made by {toy.Manufacturer} and cost {toy.Price} and has these notes {toy.GetNotes()}");

                }

            }

            foreach (ToyBox TB in toyboxes)
            {
                Console.WriteLine($"\n{TB.GetRandomToy().Name}");

            }

                   
        }

        private static Toy GetNewToyFromUser()
        {
            Console.WriteLine("Enter the Manufacturer of the toy >>");
            string manu = Console.ReadLine();

            Console.WriteLine("Enter the Name of the toy >>");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Price of the toy >>");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Notes of the toy >>");
            string notes = Console.ReadLine();

            Toy toy = new Toy()
            {
                Manufacturer = manu,
                 Name = name,
                 Price = price
            };
            //Toy x = new Toy();
            //x.Manufacturer = manu;
            toy.AddNote(notes);

            return toy;
        }
    }
}
