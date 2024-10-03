namespace TicketClassLibrary;



/// <summary>
/// Represents a Motorcycle, inherits from Vehicle.
/// </summary>
public class MC : Vehicle
{
    /// <summary>
    /// Returns the price of the motorcycle.
    /// </summary>
    /// <returns>Fixed price of 125.</returns>
    public override double Price()
    {
        double basePrice = 125;
        if (BrobizzUse)
        {
            return basePrice * 0.95; //5 procent discount  
        }

        {
            return basePrice;
        }
    }
    

    /// <summary>
    /// Returns the type of vehicle.
    /// </summary>
    /// <returns>String "MC".</returns>
    public override string VehicleType()
    {
        return "MC";
    }

    public string Licenseplate { get; set; }
    public bool IsBrobizzUsed { get; set; }
}



