using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    /// <summary>
    /// Represents a hard drive component with various specifications.
    /// </summary>
    public class HardDrive
    {
        /// <summary>
        /// Gets or sets the storage capacity in gigabytes.
        /// </summary>
        public double Capacity { get; set; }

        /// <summary>
        /// Gets or sets the type of hard drive (e.g., SSD, HDD).
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the read speed in MB/s.
        /// </summary>
        public double ReadSpeed { get; set; }

        /// <summary>
        /// Gets or sets the write speed in MB/s.
        /// </summary>
        public double WriteSpeed { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="HardDrive"/> class.
        /// </summary>
        /// <param name="capacity">The capacity in gigabytes.</param>
        /// <param name="type">The type of hard drive.</param>
        /// <param name="readSpeed">The read speed in MB/s.</param>
        /// <param name="writeSpeed">The write speed in MB/s.</param>
        /// <exception cref="ArgumentException">Thrown when any parameter is invalid.</exception>
        public HardDrive(double capacity, string type, double readSpeed, double writeSpeed)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero.", nameof(capacity));
            if (string.IsNullOrWhiteSpace(type))
                throw new ArgumentException("Type cannot be null or empty.", nameof(type));
            if (readSpeed <= 0)
                throw new ArgumentException("Read speed must be greater than zero.", nameof(readSpeed));
            if (writeSpeed <= 0)
                throw new ArgumentException("Write speed must be greater than zero.", nameof(writeSpeed));

            Capacity = capacity;
            Type = type;
            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
        }
    }
}
