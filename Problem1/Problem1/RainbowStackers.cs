using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    /// <summary>
    /// Represents a rainbow stacker toy.
    /// </summary>
    public class RainbowStackers : Toys
    {
        /// <summary>
        /// Gets or sets the number of rings in the stacker.
        /// </summary>
        public int RingCount { get; set; }

        /// <summary>
        /// Gets or sets the material type of the stacker.
        /// </summary>
        public string MaterialType { get; set; }

        /// <summary>
        /// Gets or sets the colors of the rings.
        /// </summary>
        public List<string> Colors { get; set; }

        /// <summary>
        /// Initializes a new instance of the RainbowStackers class.
        /// </summary>
        public RainbowStackers()
        {
            Cost = 24.99;
            Description = "A colorful stacking toy for developing motor skills";
            Name = "Rainbow Tower";
            ManufacturingCompany = "Educational Toys Co.";
            YearOfManufacture = 2024;
            MinimumAge = 1;
            MaximumAgeLimit = 5;
            ChokingHazard = false;
            Weight = 400; // in grams

            // Initialize specific properties
            RingCount = 7;
            MaterialType = "Wood";
            Colors = new List<string> { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };
        }

        /// <summary>
        /// Simulates stacking the rings.
        /// </summary>
        public void Stack()
        {
            Console.WriteLine($"Stacking all {RingCount} colorful rings of the {Name}!");
        }

        /// <summary>
        /// Simulates learning colors with the rainbow stacker.
        /// </summary>
        public void LearnColors()
        {
            Console.WriteLine($"Learning colors with {Name}: {string.Join(", ", Colors)}");
        }
    }
}