namespace TicketClassLibrary;

public class MC

{

    /// <summary>
    /// Får eller sætter motorcyklens nummerplade.
    /// </summary>
    /// <value>Nummerpladen som en streng.</value>
    public string LicensePlate { get; set; }

    /// <summary>
    /// Får eller sætter datoen forbundet med motorcyklen.
    /// </summary>
    /// <value>Datoen som et <see cref="DateTime"/> objekt.</value>
    public DateTime Date { get; set; }

    /// <summary>
    /// Returnerer motorcyklens faste pris.
    /// </summary>
    /// <returns>Prisen på motorcyklen som en <see cref="double"/>, som altid er 125.0.</returns>
    public double Price()
    {
        return 125.0;
    }

    /// <summary>
    /// Returnerer typen af køretøjet.
    /// </summary>
    /// <returns>En <see cref="string"/> der repræsenterer køretøjstypen, som er "MC".</returns>
    public string VehicleType()
    {
        return "MC";
    }

 
    }


