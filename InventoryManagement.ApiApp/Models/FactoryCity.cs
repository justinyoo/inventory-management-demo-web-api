namespace InventoryManagement.ApiApp.Models
{
    /// <summary>
    /// This represents the factory city entity.
    /// </summary>
    public class FactoryCity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FactoryCity" /> class.
        /// </summary>
        public FactoryCity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactoryCity" /> class.
        /// </summary>
        /// <param name="cityName">City name.</param>
        public FactoryCity(string cityName)
        {
            this.CityName = cityName;
        }

        /// <summary>
        /// Gets or sets the city name.
        /// </summary>
        public string CityName { get; set; }
    }
}