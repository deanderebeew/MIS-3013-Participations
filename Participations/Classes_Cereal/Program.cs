using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Classes_Cereal
{
    class Program
    {
        static void Main(string[] args)
        {

            //100% on exam looking at file and reading it in. To get file: Right click project, add existing item. Filter all files, select. Properties, change to copy always 

            string[] lines = File.ReadAllLines("Cereal_Data.txt");
            //              0       1           2      3
            //lines[0] = "name|manufacturer|calories|cups";

            //anytime you have a collection: dictionary, array, etc you need a loop to iterate through
            //would do a foreach except we aren't processing anything 

            List<Cereal> bowls = new List<Cereal>();

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                string[] cerealpieces = line.Split('|');

                string name = cerealpieces[0];

                Cereal c = new Cereal();
                c.Name = name;
                c.Manufacturer = cerealpieces[1];
                c.Calories = Convert.ToDouble(cerealpieces[2]);
                c.Cups = Convert.ToDouble(cerealpieces[3]);

                bowls.Add(c);

                // Console.WriteLine(c.Name);

                if (c.Cups >= 1)
                {
                    Console.WriteLine("Cereal Information:");
                    Console.WriteLine(c.Name);

                    Console.WriteLine(c.Manufacturer);

                    Console.WriteLine(c.Calories);

                    Console.WriteLine(c.Cups);
                    Console.WriteLine("\n");

                }
                else
                {

                }

            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("These cereals have no more than 100 calories");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                string[] cerealpieces = line.Split('|');

                string name = cerealpieces[0];

                Cereal c = new Cereal();
                c.Name = name;
                c.Manufacturer = cerealpieces[1];
                c.Calories = Convert.ToDouble(cerealpieces[2]);
                c.Cups = Convert.ToDouble(cerealpieces[3]);

                bowls.Add(c);

                // Console.WriteLine(c.Name);

                if (c.Calories <= 100)
                {
                    Console.WriteLine("Cereal Information:");
                    Console.WriteLine(c.Name);

                    Console.WriteLine(c.Manufacturer);

                    Console.WriteLine(c.Calories);

                    Console.WriteLine(c.Cups);
                    Console.WriteLine("\n");

                }
                else
                {

                }


            }



        }
    }
}
