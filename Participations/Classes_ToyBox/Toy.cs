using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_ToyBox
{
    public class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Notes;

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = string.Empty;

        }

        public Toy(string notes)
        {

            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = notes;
        }

        public void AddNote(string note)
        {

            Notes += note;
        }

        public string GetNotes()
        {

            return Notes;
        }


        public string GetAisle()
        {
            string aisle = "";

            Random rand = new Random();

            aisle = Manufacturer.ToUpper()[0].ToString() + rand.Next(1,25);


            return aisle;

        }

    }
}
