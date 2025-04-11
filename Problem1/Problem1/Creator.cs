namespace Problem1
{
    /// <summary>
    /// Factory for creating toy objects.
    /// </summary>
    public class Creator
    {
        /// <summary>
        /// Creates a toy object of the specified type.
        /// </summary>
        /// <param name="type">Type of toy to create (converted to lowercase and spaces removed)</param>
        /// <returns>A new toy object</returns>
        /// <exception cref="NotSupportedException">Thrown when type is not supported</exception>
        public Toys GetToy(string type)
        {
            type = type.ToLower();
            type = type.Replace(" ", "");
            switch (type)
            {
                case "cars":
                    return new Cars();
                case "dollhouses":
                    return new Dollhouses();
                case "stuffedanimals":
                    return new StuffedAnimals();
                case "rainbowstackers":
                    return new RainbowStackers();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}