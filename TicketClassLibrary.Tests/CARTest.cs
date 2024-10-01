using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

namespace TicketClassLibrary.Tests
{
    /// <summary>
    /// Test class for the <see cref="CAR"/> class.
    /// </summary>
    [TestClass]
    public class CARTest
    {
        /// <summary>
        /// Tests that the <see cref="CAR.Price"/> method returns a fixed price of 240.
        /// </summary>
        [TestMethod]
        public void Price_ShouldReturnFixedValue()
        {
            // Create a new instance of the CAR class.
            var car = new Car();
            
            // Retrieve the price from the Price method.
            var price = car.Price();
            
            // Assert that the price is 240.0.
            Assert.AreEqual(240.0, price);
        }
        
        /// <summary>
        /// Tests that the <see cref="CAR.VehicleType"/> method returns the string "Car".
        /// </summary>
        [TestMethod]
        public void VehicleType_ShouldReturnCar()
        {
            // Create a new instance of the CAR class.
            var car = new Car();
            
            // Retrieve the vehicle type from the VehicleType method.
            var vehicleType = car.VehicleType();
            
            // Assert that the vehicle type is "Car".
            Assert.AreEqual("Car", vehicleType);
        }
    }
}
