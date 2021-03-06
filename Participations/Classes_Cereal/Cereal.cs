﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Cereal
{
    public class Cereal
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Calories { get; set; }

        public double Cups { get; set; }

        //ctor to set starting values for properties of class
        public Cereal()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Calories = 0;
            Cups = 0;
        }

        public override string ToString()
        {
            return $"{Name} made by {Manufacturer} has a serving size of {Cups.ToString("N1")} and has {Calories.ToString("N2")} calories";
        }

    }
}
