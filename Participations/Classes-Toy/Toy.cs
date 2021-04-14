using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Toy
{
    class Toy
    {
        public string Manufacturer { get; set; }
        
        public string Name { get; set; }

        public double Price { get; set; }

        private string Notes { get; set; }


        public Toy()
        {
            Manufacturer = String.Empty;
            Name = String.Empty;
            Price = 0;
            Notes = String.Empty;


        }


        public Toy(string manufacturer, double price, string name, string notes)
        {
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Name = name;
            this.Notes = notes;

        }

        public string GetAisle()
        {
            Random rand = new Random();
            int number = rand.Next(1, 25);
            string firstletter = Manufacturer.ToUpper()[0].ToString() + number;

            return firstletter; 
             
        }

        public string GetNotes()
        {
            return Notes;
        }
        
        public void SetNotes(string notes)
        {
            Notes = notes;
        }
    }
}
