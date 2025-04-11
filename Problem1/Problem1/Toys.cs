using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    /// <summary>
    /// Abstract base class for all toy types.
    /// </summary>
    public abstract class Toys
    {
        /// <summary>
        /// Gets or sets the cost of the toy.
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// Gets or sets the description of the toy.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the name of the toy.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the manufacturing company of the toy.
        /// </summary>
        public string ManufacturingCompany { get; set; }

        /// <summary>
        /// Gets or sets the year of manufacture of the toy.
        /// </summary>
        public int YearOfManufacture { get; set; }

        /// <summary>
        /// Gets or sets the minimum age recommended for the toy.
        /// </summary>
        public int MinimumAge { get; set; }

        /// <summary>
        /// Gets or sets the maximum age limit recommended for the toy.
        /// </summary>
        public int MaximumAgeLimit { get; set; }

        /// <summary>
        /// Gets or sets whether the toy contains parts that could be a choking hazard.
        /// </summary>
        public bool ChokingHazard { get; set; }

        /// <summary>
        /// Gets or sets the weight of the toy in grams.
        /// </summary>
        public int Weight { get; set; }
    }
}