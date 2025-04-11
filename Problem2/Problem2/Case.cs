using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{

    /// <summary>
    /// Represents a computer case component with various specifications.
    /// StAuth10068: I Sneha Philip, 000801922 certify that this material is my original work. No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.
    /// </summary>
    public class Case
    {
        /// <summary>
        /// Gets or sets the length in mm.
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Gets or sets the width in mm.
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Gets or sets the height in mm.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Gets or sets the number of fans.
        /// </summary>
        public int NumberOfFans { get; set; }

        /// <summary>
        /// Gets or sets the number of vents.
        /// </summary>
        public int NumberOfVents { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Case"/> class.
        /// </summary>
        /// <param name="length">The length in mm.</param>
        /// <param name="width">The width in mm.</param>
        /// <param name="height">The height in mm.</param>
        /// <param name="numberOfFans">The number of fans.</param>
        /// <param name="numberOfVents">The number of vents.</param>
        /// <exception cref="ArgumentException">Thrown when any parameter is invalid.</exception>
        public Case(double length, double width, double height, int numberOfFans, int numberOfVents)
        {
            if (length <= 0)
                throw new ArgumentException("Length must be greater than zero.", nameof(length));
            if (width <= 0)
                throw new ArgumentException("Width must be greater than zero.", nameof(width));
            if (height <= 0)
                throw new ArgumentException("Height must be greater than zero.", nameof(height));
            if (numberOfFans < 0)
                throw new ArgumentException("Number of fans cannot be negative.", nameof(numberOfFans));
            if (numberOfVents < 0)
                throw new ArgumentException("Number of vents cannot be negative.", nameof(numberOfVents));

            Length = length;
            Width = width;
            Height = height;
            NumberOfFans = numberOfFans;
            NumberOfVents = numberOfVents;
        }
    }
}
