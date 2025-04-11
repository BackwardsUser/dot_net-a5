using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    /// <summary>
    /// Represents a CPU component with various specifications.
    /// </summary>
    public class CPU
    {
        /// <summary>
        /// Gets or sets the clock speed in GHz.
        /// </summary>
        public double Speed { get; set; }

        /// <summary>
        /// Gets or sets the manufacturer name.
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Gets or sets the socket type.
        /// </summary>
        public string SocketType { get; set; }

        /// <summary>
        /// Gets or sets the cache size in MB.
        /// </summary>
        public double CacheSize { get; set; }

        /// <summary>
        /// Gets or sets the number of cores.
        /// </summary>
        public int NumberOfCores { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CPU"/> class.
        /// </summary>
        /// <param name="speed">The clock speed in GHz.</param>
        /// <param name="manufacturer">The manufacturer name.</param>
        /// <param name="socketType">The socket type.</param>
        /// <param name="cacheSize">The cache size in MB.</param>
        /// <param name="numberOfCores">The number of cores.</param>
        /// <exception cref="ArgumentException">Thrown when any parameter is invalid.</exception>
        public CPU(double speed, string manufacturer, string socketType, double cacheSize, int numberOfCores)
        {
            if (speed <= 0)
                throw new ArgumentException("Speed must be greater than zero.", nameof(speed));
            if (string.IsNullOrWhiteSpace(manufacturer))
                throw new ArgumentException("Manufacturer cannot be null or empty.", nameof(manufacturer));
            if (string.IsNullOrWhiteSpace(socketType))
                throw new ArgumentException("Socket type cannot be null or empty.", nameof(socketType));
            if (cacheSize <= 0)
                throw new ArgumentException("Cache size must be greater than zero.", nameof(cacheSize));
            if (numberOfCores <= 0)
                throw new ArgumentException("Number of cores must be greater than zero.", nameof(numberOfCores));

            Speed = speed;
            Manufacturer = manufacturer;
            SocketType = socketType;
            CacheSize = cacheSize;
            NumberOfCores = numberOfCores;
        }
    }

}
