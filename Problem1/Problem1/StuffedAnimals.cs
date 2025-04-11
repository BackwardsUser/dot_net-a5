using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    /// <summary>
    /// Represents a stuffed animal toy.
    /// </summary>
    public class StuffedAnimals : Toys
    {
        /// <summary>
        /// Gets or sets the type of animal.
        /// </summary>
        public string AnimalType { get; set; }

        /// <summary>
        /// Gets or sets the type of fabric used.
        /// </summary>
        public string FabricType { get; set; }

        /// <summary>
        /// Gets or sets whether the stuffed animal is squeezable.
        /// </summary>
        public bool IsSqueezable { get; set; }

        /// <summary>
        /// Initializes a new instance of the StuffedAnimals class.
        /// </summary>
        public StuffedAnimals()
        {
            Cost = 19.99;
            Description = "A soft and cuddly stuffed animal";
            Name = "Fluffy Friend";
            ManufacturingCompany = "Cuddle Toys Inc.";
            YearOfManufacture = 2023;
            MinimumAge = 0;
            MaximumAgeLimit = 12;
            ChokingHazard = false;
            Weight = 300; // in grams

            // Initialize specific properties
            AnimalType = "Teddy Bear";
            FabricType = "Plush";
            IsSqueezable = true;
        }

        /// <summary>
        /// Simulates cuddling with the stuffed animal.
        /// </summary>
        public void Cuddle()
        {
            Console.WriteLine($"Cuddling with the soft {AnimalType} named {Name}!");
        }

        /// <summary>
        /// Simulates the stuffed animal making a sound when squeezed.
        /// </summary>
        public void MakeSound()
        {
            if (IsSqueezable)
            {
                Console.WriteLine($"{Name} the {AnimalType} makes a cute sound when squeezed!");
            }
            else
            {
                Console.WriteLine($"{Name} the {AnimalType} is silent and soft.");
            }
        }
    }
}