using System.Xml.Linq;

namespace Problem2
{


    /// <summary>
    /// Director class that controls the construction process.
    /// </summary>
    public class ComputerDirector
    {
        /// <summary>
        /// Constructs a computer using the provided builder.
        /// </summary>
        /// <typeparam name="T">The type of computer to build.</typeparam>
        /// <param name="builder">The builder to use.</param>
        /// <returns>The built computer.</returns>
        public T Construct<T>(IComputerBuilder<T> builder) where T : Computer
        {
            return builder.Build();
        }
    }
}
