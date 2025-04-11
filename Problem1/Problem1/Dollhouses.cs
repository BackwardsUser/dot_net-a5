using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    /// <summary>
    /// Represents a toy dollhouse.
    /// </summary>
    public class Dollhouses : Toys
    {
        /// <summary>
        /// Gets or sets the number of rooms in the dollhouse.
        /// </summary>
        public int NumberOfRooms { get; set; }

        /// <summary>
        /// Gets or sets whether the dollhouse has furniture.
        /// </summary>
        public bool HasFurniture { get; set; }

        /// <summary>
        /// Gets or sets the theme of the dollhouse.
        /// </summary>
        public string Theme { get; set; }

        /// <summary>
        /// Initializes a new instance of the Dollhouses class.
        /// </summary>
        public Dollhouses()
        {
            Cost = 49.99;
            Description = "A beautiful miniature house for dolls";
            Name = "Dream Mansion";
            ManufacturingCompany = "Tiny Homes Co.";
            YearOfManufacture = 2024;
            MinimumAge = 4;
            MaximumAgeLimit = 12;
            ChokingHazard = true;
            Weight = 1500; // in grams

            // Initialize specific properties
            NumberOfRooms = 6;
            HasFurniture = true;
            Theme = "Victorian";
        }

        /// <summary>
        /// Simulates decorating the dollhouse.
        /// </summary>
        public void Decorate()
        {
            Console.WriteLine($"Decorating the {Theme} dollhouse with {NumberOfRooms} rooms!");
        }

        /// <summary>
        /// Simulates renovating the dollhouse.
        /// </summary>
        public void Renovate()
        {
            Console.WriteLine($"Renovating {Name} dollhouse with new furniture and accessories!");
        }
    }
}