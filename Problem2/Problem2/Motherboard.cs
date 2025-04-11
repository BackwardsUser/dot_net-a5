using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    /// <summary>
    /// Represents a motherboard component with various specifications.
    /// </summary>
    public class Motherboard
    {
        /// <summary>
        /// Gets or sets the number of memory slots.
        /// </summary>
        public int NumberOfMemorySlots { get; set; }
        //hello

        /// <summary>
        /// Gets or sets the power consumption in watts.
        /// </summary>
        public double PowerConsumption { get; set; }

        /// <summary>
        /// Gets or sets the number of PCI slots.
        /// </summary>
        public int NumberOfPCISlots { get; set; }

        /// <summary>
        /// Gets or sets the form factor (e.g., ATX, Micro-ATX).
        /// </summary>
        public string FormFactor { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of hard drives supported.
        /// </summary>
        public int HardDriveLimit { get; set; }

        /// <summary>
        /// Gets or sets the supported CPU socket type.
        /// </summary>
        public string CPUSocketType { get; set; }

        /// <summary>
        /// Gets or sets the supported memory type.
        /// </summary>
        public string MemoryType { get; set; }

        /// <summary>
        /// Gets or sets the supported graphics card interface.
        /// </summary>
        public string GraphicsCardInterface { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Motherboard"/> class.
        /// </summary>
        /// <param name="numberOfMemorySlots">The number of memory slots.</param>
        /// <param name="powerConsumption">The power consumption in watts.</param>
        /// <param name="numberOfPCISlots">The number of PCI slots.</param>
        /// <param name="formFactor">The form factor.</param>
        /// <param name="hardDriveLimit">The maximum number of hard drives supported.</param>
        /// <param name="cpuSocketType">The supported CPU socket type.</param>
        /// <param name="memoryType">The supported memory type.</param>
        /// <param name="graphicsCardInterface">The supported graphics card interface.</param>
        /// <exception cref="ArgumentException">Thrown when any parameter is invalid.</exception>
        public Motherboard(int numberOfMemorySlots, double powerConsumption, int numberOfPCISlots, string formFactor,
                           int hardDriveLimit, string cpuSocketType, string memoryType, string graphicsCardInterface)
        {
            if (numberOfMemorySlots <= 0)
                throw new ArgumentException("Number of memory slots must be greater than zero.", nameof(numberOfMemorySlots));
            if (powerConsumption <= 0)
                throw new ArgumentException("Power consumption must be greater than zero.", nameof(powerConsumption));
            if (numberOfPCISlots < 0)
                throw new ArgumentException("Number of PCI slots cannot be negative.", nameof(numberOfPCISlots));
            if (string.IsNullOrWhiteSpace(formFactor))
                throw new ArgumentException("Form factor cannot be null or empty.", nameof(formFactor));
            if (hardDriveLimit <= 0)
                throw new ArgumentException("Hard drive limit must be greater than zero.", nameof(hardDriveLimit));
            if (string.IsNullOrWhiteSpace(cpuSocketType))
                throw new ArgumentException("CPU socket type cannot be null or empty.", nameof(cpuSocketType));
            if (string.IsNullOrWhiteSpace(memoryType))
                throw new ArgumentException("Memory type cannot be null or empty.", nameof(memoryType));
            if (string.IsNullOrWhiteSpace(graphicsCardInterface))
                throw new ArgumentException("Graphics card interface cannot be null or empty.", nameof(graphicsCardInterface));

            NumberOfMemorySlots = numberOfMemorySlots;
            PowerConsumption = powerConsumption;
            NumberOfPCISlots = numberOfPCISlots;
            FormFactor = formFactor;
            HardDriveLimit = hardDriveLimit;
            CPUSocketType = cpuSocketType;
            MemoryType = memoryType;
            GraphicsCardInterface = graphicsCardInterface;
        }
    }
}
