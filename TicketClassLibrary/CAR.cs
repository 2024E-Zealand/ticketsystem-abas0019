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
        return 240;
    }

    /// <summary>
    /// Returns the type of vehicle.
    /// </summary>
    /// <returns>String "Car".</returns>
    public override string VehicleType()
    {
        return "Car";
    }
}
