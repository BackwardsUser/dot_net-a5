using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    /// <summary>
    /// Defines the interface for computer builders.
    /// </summary>
    /// <typeparam name="T">The type of computer to build.</typeparam>
    public interface IComputerBuilder<out T> where T : Computer
    {
        /// <summary>
        /// Adds a hard drive to the computer being built.
        /// </summary>
        /// <param name="capacity">The capacity in GB.</param>
        /// <param name="type">The type of hard drive.</param>
        /// <param name="readSpeed">The read speed in MB/s.</param>
        /// <param name="writeSpeed">The write speed in MB/s.</param>
        /// <returns>The current builder instance for method chaining.</returns>
        IComputerBuilder<T> AddHardDrive(double capacity, string type, double readSpeed, double writeSpeed);

        /// <summary>
        /// Adds a motherboard to the computer being built.
        /// </summary>
        /// <param name="numberOfMemorySlots">The number of memory slots.</param>
        /// <param name="powerConsumption">The power consumption in watts.</param>
        /// <param name="numberOfPCISlots">The number of PCI slots.</param>
        /// <param name="formFactor">The form factor.</param>
        /// <param name="hardDriveLimit">The maximum number of hard drives supported.</param>
        /// <param name="cpuSocketType">The supported CPU socket type.</param>
        /// <param name="memoryType">The supported memory type.</param>
        /// <param name="graphicsCardInterface">The supported graphics card interface.</param>
        /// <returns>The current builder instance for method chaining.</returns>
        IComputerBuilder<T> AddMotherboard(int numberOfMemorySlots, double powerConsumption, int numberOfPCISlots, string formFactor,
                                          int hardDriveLimit, string cpuSocketType, string memoryType, string graphicsCardInterface);

        /// <summary>
        /// Adds a CPU to the computer being built.
        /// </summary>
        /// <param name="speed">The clock speed in GHz.</param>
        /// <param name="manufacturer">The manufacturer name.</param>
        /// <param name="socketType">The socket type.</param>
        /// <param name="cacheSize">The cache size in MB.</param>
        /// <param name="numberOfCores">The number of cores.</param>
        /// <returns>The current builder instance for method chaining.</returns>
        IComputerBuilder<T> AddCpu(double speed, string manufacturer, string socketType, double cacheSize, int numberOfCores);

        /// <summary>
        /// Adds memory to the computer being built.
        /// </summary>
        /// <param name="readSpeed">The read speed in MB/s.</param>
        /// <param name="writeSpeed">The write speed in MB/s.</param>
        /// <param name="type">The type of memory.</param>
        /// <param name="amountInGB">The amount of memory in GB.</param>
        /// <returns>The current builder instance for method chaining.</returns>
        IComputerBuilder<T> AddMemory(double readSpeed, double writeSpeed, string type, double amountInGB);

        /// <summary>
        /// Adds a graphics card to the computer being built.
        /// </summary>
        /// <param name="fanCount">The number of fans.</param>
        /// <param name="speed">The clock speed in MHz.</param>
        /// <param name="videoMemory">The amount of video memory in GB.</param>
        /// <param name="numberOfCUDACores">The number of CUDA cores.</param>
        /// <returns>The current builder instance for method chaining.</returns>
        IComputerBuilder<T> AddGraphicsCard(int fanCount, double speed, double videoMemory, int numberOfCUDACores);

        /// <summary>
        /// Adds a case to the computer being built.
        /// </summary>
        /// <param name="length">The length in mm.</param>
        /// <param name="width">The width in mm.</param>
        /// <param name="height">The height in mm.</param>
        /// <param name="numberOfFans">The number of fans.</param>
        /// <param name="numberOfVents">The number of vents.</param>
        /// <returns>The current builder instance for method chaining.</returns>
        IComputerBuilder<T> AddCase(double length, double width, double height, int numberOfFans, int numberOfVents);

        /// <summary>
        /// Builds and returns the computer.
        /// </summary>
        /// <returns>The built computer.</returns>
        T Build();
    }

}
