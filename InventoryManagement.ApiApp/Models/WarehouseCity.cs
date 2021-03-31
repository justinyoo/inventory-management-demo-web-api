namespace InventoryManagement.ApiApp.Models
{
    /// <summary>
    /// This represents the factory city entity.
    /// </summary>
    public class WarehouseCity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseCity" /> class.
        /// </summary>
        public WarehouseCity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseCity" /> class.
        /// </summary>
        /// <param name="cityName">City name.</param>
        public WarehouseCity(string cityName)
        {
            this.CityName = cityName;
        }

        /// <summary>
        /// Gets or sets the city name.
        /// </summary>
        public string CityName { get; set; }
    }
}