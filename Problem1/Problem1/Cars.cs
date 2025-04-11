using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    /// <summary>
    /// Represents a toy car.
    /// </summary>
    public class Cars : Toys
    {
        /// <summary>
        /// Gets or sets the type of car.
        /// </summary>
        public string CarType { get; set; }

        /// <summary>
        /// Gets or sets the material the car is made of.
        /// </summary>
        public string Material { get; set; }

        /// <summary>
        /// Gets or sets whether the car has functioning lights.
        /// </summary>
        public bool HasLights { get; set; }

        /// <summary>
        /// Initializes a new instance of the Cars class.
        /// </summary>
        public Cars()
        {
            Cost = 15.99;
            Description = "A miniature toy car for play";
            Name = "Speedy Racer";
            ManufacturingCompany = "ToyWheels Inc.";
            YearOfManufacture = 2023;
            MinimumAge = 3;
            MaximumAgeLimit = 10;
            ChokingHazard = false;
            Weight = 200; // in grams

            // Initialize specific properties
            CarType = "Race car";
            Material = "Die-cast metal";
            HasLights = true;
        }

        /// <summary>
        /// Simulates the car racing.
        /// </summary>
        public void Race()
        {
            Console.WriteLine($"{Name} is racing at high speed!");
        }

        /// <summary>
        /// Simulates the car honking.
        /// </summary>
        public void Honk()
        {
            Console.WriteLine($"{Name} honks loudly! Beep beep!");
        }
    }
}