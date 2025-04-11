using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    /// <summary>
    /// Represents a memory component with various specifications.
    /// </summary>
    public class Memory
    {
        /// <summary>
        /// Gets or sets the read speed in MB/s.
        /// </summary>
        public double ReadSpeed { get; set; }

        /// <summary>
        /// Gets or sets the write speed in MB/s.
        /// </summary>
        public double WriteSpeed { get; set; }

        /// <summary>
        /// Gets or sets the type of memory (e.g., DDR4, DDR5).
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the amount of memory in GB.
        /// </summary>
        public double AmountInGB { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Memory"/> class.
        /// </summary>
        /// <param name="readSpeed">The read speed in MB/s.</param>
        /// <param name="writeSpeed">The write speed in MB/s.</param>
        /// <param name="type">The type of memory.</param>
        /// <param name="amountInGB">The amount of memory in GB.</param>
        /// <exception cref="ArgumentException">Thrown when any parameter is invalid.</exception>
        public Memory(double readSpeed, double writeSpeed, string type, double amountInGB)
        {
            if (readSpeed <= 0)
                throw new ArgumentException("Read speed must be greater than zero.", nameof(readSpeed));
            if (writeSpeed <= 0)
                throw new ArgumentException("Write speed must be greater than zero.", nameof(writeSpeed));
            if (string.IsNullOrWhiteSpace(type))
                throw new ArgumentException("Type cannot be null or empty.", nameof(type));
            if (amountInGB <= 0)
                throw new ArgumentException("Amount must be greater than zero.", nameof(amountInGB));

            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
            Type = type;
            AmountInGB = amountInGB;
        }
    }

}
