using TicketClassLibrary;

namespace TicketClassLibrary;
/// <summary>
/// Represents a Car, inherits from Vehicle.
/// </summary>
public class Car : Vehicle
{
    /// <summary>
    /// Returns the price of the car.
    /// </summary>
    /// <returns>Fixed price of 240.</returns>
    public override double Price()
    {
        double basePrice = 240;
        if (BrobizzUse)
        {
            return basePrice * 0.95; //5 procent discount
        }
        return basePrice;
    }

    /// <summary>
    /// Returns the type of vehicle.
    /// </summary>
    /// <returns>String "Car".</returns>
    public override string VehicleType()
    {
        return "Car";
    }

    public string Licenseplate { get; set; }
    public bool IsBrobizzUsed { get; set; }
}
  
