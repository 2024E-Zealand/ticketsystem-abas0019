namespace TicketClassLibrary;

public abstract class Vehicle
    
{
    /// <summary>
    /// License plate of the vehicle
    /// </summary>
    public string Licenseplate { get; set; }

    /// <summary>
    /// Date of ticket purchase
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Abstract method for price, to be implemented by derived classes
    /// </summary>
    /// <returns>Price of the vehicle</returns>
    public abstract double Price();

    /// <summary>
    /// Abstract method for vehicle type, to be implemented by derived classes
    /// </summary>
    /// <returns>Type of the vehicle</returns>
    public abstract string VehicleType();
}
