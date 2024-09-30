namespace TicketClassLibrary;

    public class CAR 
    {
        // Property to store the license plate of the car
        public string LicensePlate { get; set; }

        // Property to store the date associated with the car
        public DateTime Date { get; set; }

        // Method to return the fixed price of the car
        public double Price()
        {
            return 240.0;
        }

        // Method to return the type of the vehicle
        public string VehicleType()
        {
            return "Car";
        }
    }

