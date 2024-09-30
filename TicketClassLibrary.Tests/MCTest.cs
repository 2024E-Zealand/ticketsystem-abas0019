using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

namespace TicketClassLibrary.Tests
{
    /// <summary>
    /// Testklasse for <see cref="MC"/> klassen.
    /// </summary>
    [TestClass]
    public class MCTest
    {
        /// <summary>
        /// Tester at <see cref="MC.Price"/> metoden returnerer en fast pris på 125.
        /// </summary>
        [TestMethod]
        public void Price_ShouldReturnFixedValue()
        {
            // Opret en ny instans af MC klassen.
            var mc = new MC();

            // Hent prisen fra Price metoden.
            var price = mc.Price();

            // Bekræft at prisen er 125.0.
            Assert.AreEqual(125.0, price);
        }

        /// <summary>
        /// Tester at <see cref="MC.Vehicle"/> metoden returnerer string "MC".
        /// </summary>
        [TestMethod]
        public void Vehicle_ShouldReturnMC()
        {
            // Opret en ny instans af MC klassen.
            var mc = new MC();

            // Hent køretøjstypen fra Vehicle metoden.
            var vehicleType = mc.VehicleType();

            // Bekræft at køretøjstypen er "MC".
            Assert.AreEqual("MC", vehicleType);
        }
    }
}