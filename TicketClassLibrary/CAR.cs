namespace TicketClassLibrary
{
    /// <summary>
    /// Represents a car and provides methods related to its properties and pricing.
    /// </summary>
    public class CAR 
    {
        /// <summary>
        /// Gets or sets the license plate of the car.
        /// </summary>
        /// <value>The license plate as a string.</value>
        public string LicensePlate { get; set; }

        /// <summary>
        /// Gets or sets the date associated with the car.
        /// </summary>
        /// <value>The date as a <see cref="DateTime"/> object.</value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the fixed price of the car.
        /// </summary>
        /// <returns>The price of the car as a <see cref="double"/>, which is always 240.0.</returns>
        public double Price()
        {
            return 240.0;
        }

        /// <summary>
        /// Returns the type of the vehicle.
        /// </summary>
        /// <returns>A <see cref="string"/> that represents the vehicle type, which is "Car".</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}