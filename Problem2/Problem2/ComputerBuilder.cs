using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{

    /// <summary>
    /// A concrete computer builder that constructs a computer instance.
    /// </summary>
    public class ComputerBuilder : IComputerBuilder<Computer>
    {
        private readonly Computer _computer;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerBuilder"/> class.
        /// </summary>
        public ComputerBuilder()
        {
            _computer = new Computer();
        }

        /// <inheritdoc/>
        public IComputerBuilder<Computer> AddHardDrive(double capacity, string type, double readSpeed, double writeSpeed)
        {
            _computer.AddHardDrive(capacity, type, readSpeed, writeSpeed);
            return this;
        }

        /// <inheritdoc/>
        public IComputerBuilder<Computer> AddMotherboard(int numberOfMemorySlots, double powerConsumption, int numberOfPCISlots, string formFactor,
                                                       int hardDriveLimit, string cpuSocketType, string memoryType, string graphicsCardInterface)
        {
            _computer.AddMotherboard(numberOfMemorySlots, powerConsumption, numberOfPCISlots, formFactor,
                                    hardDriveLimit, cpuSocketType, memoryType, graphicsCardInterface);
            return this;
        }

        /// <inheritdoc/>
        public IComputerBuilder<Computer> AddCpu(double speed, string manufacturer, string socketType, double cacheSize, int numberOfCores)
        {
            _computer.AddCpu(speed, manufacturer, socketType, cacheSize, numberOfCores);
            return this;
        }

        /// <inheritdoc/>
        public IComputerBuilder<Computer> AddMemory(double readSpeed, double writeSpeed, string type, double amountInGB)
        {
            _computer.AddMemory(readSpeed, writeSpeed, type, amountInGB);
            return this;
        }

        /// <inheritdoc/>
        public IComputerBuilder<Computer> AddGraphicsCard(int fanCount, double speed, double videoMemory, int numberOfCUDACores)
        {
            _computer.AddGraphicsCard(fanCount, speed, videoMemory, numberOfCUDACores);
            return this;
        }

        /// <inheritdoc/>
        public IComputerBuilder<Computer> AddCase(double length, double width, double height, int numberOfFans, int numberOfVents)
        {
            _computer.AddCase(length, width, height, numberOfFans, numberOfVents);
            return this;
        }

        /// <inheritdoc/>
        public Computer Build()
        {
            List<string> compatibilityIssues = _computer.ValidateCompatibility();
            if (compatibilityIssues.Count > 0)
            {
                throw new InvalidOperationException(
                    $"Cannot build computer due to compatibility issues:{Environment.NewLine}{string.Join(Environment.NewLine, compatibilityIssues)}");
            }

            return _computer;
        }
    }
}
