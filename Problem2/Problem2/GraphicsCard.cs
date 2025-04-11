using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    /// <summary>
    /// Represents a graphics card component with various specifications.
    /// </summary>
    public class GraphicsCard
    {
        /// <summary>
        /// Gets or sets the number of fans.
        /// </summary>
        public int FanCount { get; set; }

        /// <summary>
        /// Gets or sets the clock speed in MHz.
        /// </summary>
        public double Speed { get; set; }

        /// <summary>
        /// Gets or sets the amount of video memory in GB.
        /// </summary>
        public double VideoMemory { get; set; }

        /// <summary>
        /// Gets or sets the number of CUDA cores.
        /// </summary>
        public int NumberOfCUDACores { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphicsCard"/> class.
        /// </summary>
        /// <param name="fanCount">The number of fans.</param>
        /// <param name="speed">The clock speed in MHz.</param>
        /// <param name="videoMemory">The amount of video memory in GB.</param>
        /// <param name="numberOfCUDACores">The number of CUDA cores.</param>
        /// <exception cref="ArgumentException">Thrown when any parameter is invalid.</exception>
        public GraphicsCard(int fanCount, double speed, double videoMemory, int numberOfCUDACores)
        {
            if (fanCount <= 0)
                throw new ArgumentException("Fan count must be greater than zero.", nameof(fanCount));
            if (speed <= 0)
                throw new ArgumentException("Speed must be greater than zero.", nameof(speed));
            if (videoMemory <= 0)
                throw new ArgumentException("Video memory must be greater than zero.", nameof(videoMemory));
            if (numberOfCUDACores <= 0)
                throw new ArgumentException("Number of CUDA cores must be greater than zero.", nameof(numberOfCUDACores));

            FanCount = fanCount;
            Speed = speed;
            VideoMemory = videoMemory;
            NumberOfCUDACores = numberOfCUDACores;
        }
    }
}
