using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    /// <summary>
    /// Represents a computer with various components.
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// Gets or sets the hard drive component.
        /// </summary>
        public HardDrive HardDrive { get; set; }

        /// <summary>
        /// Gets or sets the motherboard component.
        /// </summary>
        public Motherboard Motherboard { get; set; }

        /// <summary>
        /// Gets or sets the CPU component.
        /// </summary>
        public CPU Cpu { get; set; }

        /// <summary>
        /// Gets or sets the memory component.
        /// </summary>
        public Memory Memory { get; set; }

        /// <summary>
        /// Gets or sets the graphics card component.
        /// </summary>
        public GraphicsCard GraphicsCard { get; set; }

        /// <summary>
        /// Gets or sets the case component.
        /// </summary>
        public Case Case { get; set; }

        /// <summary>
        /// Adds a hard drive to the computer.
        /// </summary>
        /// <param name="capacity">The capacity in GB.</param>
        /// <param name="type">The type of hard drive.</param>
        /// <param name="readSpeed">The read speed in MB/s.</param>
        /// <param name="writeSpeed">The write speed in MB/s.</param>
        public void AddHardDrive(double capacity, string type, double readSpeed, double writeSpeed)
        {
            HardDrive = new HardDrive(capacity, type, readSpeed, writeSpeed);
        }

        /// <summary>
        /// Adds a motherboard to the computer.
        /// </summary>
        /// <param name="numberOfMemorySlots">The number of memory slots.</param>
        /// <param name="powerConsumption">The power consumption in watts.</param>
        /// <param name="numberOfPCISlots">The number of PCI slots.</param>
        /// <param name="formFactor">The form factor.</param>
        /// <param name="hardDriveLimit">The maximum number of hard drives supported.</param>
        /// <param name="cpuSocketType">The supported CPU socket type.</param>
        /// <param name="memoryType">The supported memory type.</param>
        /// <param name="graphicsCardInterface">The supported graphics card interface.</param>
        public void AddMotherboard(int numberOfMemorySlots, double powerConsumption, int numberOfPCISlots, string formFactor,
                                 int hardDriveLimit, string cpuSocketType, string memoryType, string graphicsCardInterface)
        {
            Motherboard = new Motherboard(numberOfMemorySlots, powerConsumption, numberOfPCISlots, formFactor,
                                         hardDriveLimit, cpuSocketType, memoryType, graphicsCardInterface);
        }

        /// <summary>
        /// Adds a CPU to the computer.
        /// </summary>
        /// <param name="speed">The clock speed in GHz.</param>
        /// <param name="manufacturer">The manufacturer name.</param>
        /// <param name="socketType">The socket type.</param>
        /// <param name="cacheSize">The cache size in MB.</param>
        /// <param name="numberOfCores">The number of cores.</param>
        public void AddCpu(double speed, string manufacturer, string socketType, double cacheSize, int numberOfCores)
        {
            Cpu = new CPU(speed, manufacturer, socketType, cacheSize, numberOfCores);
        }

        /// <summary>
        /// Adds memory to the computer.
        /// </summary>
        /// <param name="readSpeed">The read speed in MB/s.</param>
        /// <param name="writeSpeed">The write speed in MB/s.</param>
        /// <param name="type">The type of memory.</param>
        /// <param name="amountInGB">The amount of memory in GB.</param>
        public void AddMemory(double readSpeed, double writeSpeed, string type, double amountInGB)
        {
            Memory = new Memory(readSpeed, writeSpeed, type, amountInGB);
        }

        /// <summary>
        /// Adds a graphics card to the computer.
        /// </summary>
        /// <param name="fanCount">The number of fans.</param>
        /// <param name="speed">The clock speed in MHz.</param>
        /// <param name="videoMemory">The amount of video memory in GB.</param>
        /// <param name="numberOfCUDACores">The number of CUDA cores.</param>
        public void AddGraphicsCard(int fanCount, double speed, double videoMemory, int numberOfCUDACores)
        {
            GraphicsCard = new GraphicsCard(fanCount, speed, videoMemory, numberOfCUDACores);
        }

        /// <summary>
        /// Adds a case to the computer.
        /// </summary>
        /// <param name="length">The length in mm.</param>
        /// <param name="width">The width in mm.</param>
        /// <param name="height">The height in mm.</param>
        /// <param name="numberOfFans">The number of fans.</param>
        /// <param name="numberOfVents">The number of vents.</param>
        public void AddCase(double length, double width, double height, int numberOfFans, int numberOfVents)
        {
            Case = new Case(length, width, height, numberOfFans, numberOfVents);
        }

        /// <summary>
        /// Validates the compatibility of all components.
        /// </summary>
        /// <returns>A list of compatibility issues found, empty if no issues.</returns>
        public List<string> ValidateCompatibility()
        {
            var issues = new List<string>();

            // Verify all required components are present
            if (HardDrive == null) issues.Add("Hard drive is missing");
            if (Motherboard == null) issues.Add("Motherboard is missing");
            if (Cpu == null) issues.Add("CPU is missing");
            if (Memory == null) issues.Add("Memory is missing");
            if (GraphicsCard == null) issues.Add("Graphics card is missing");
            if (Case == null) issues.Add("Case is missing");

            // If any component is missing, we can't validate further compatibility
            if (issues.Count > 0)
                return issues;

            // Check CPU socket compatibility with motherboard
            if (Cpu.SocketType != Motherboard.CPUSocketType)
                issues.Add($"CPU socket type '{Cpu.SocketType}' is incompatible with motherboard socket type '{Motherboard.CPUSocketType}'");

            // Check memory type compatibility with motherboard
            if (Memory.Type != Motherboard.MemoryType)
                issues.Add($"Memory type '{Memory.Type}' is incompatible with motherboard memory type '{Motherboard.MemoryType}'");

            // Check case dimensions vs motherboard form factor (simplistic check)
            if (Motherboard.FormFactor == "ATX" && (Case.Width < 244 || Case.Height < 305))
                issues.Add("Case is too small for ATX motherboard");
            else if (Motherboard.FormFactor == "Micro-ATX" && (Case.Width < 244 || Case.Height < 244))
                issues.Add("Case is too small for Micro-ATX motherboard");
            else if (Motherboard.FormFactor == "Mini-ITX" && (Case.Width < 170 || Case.Height < 170))
                issues.Add("Case is too small for Mini-ITX motherboard");

            return issues;
        }
    }
}
