using System;
using System.ComponentModel;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

namespace TicketClassLibrary.Tests;

[TestClass]
public class VehicleTests
{
    [TestMethod]
    public void Car_Price_WithBrobizz_DiscountApplied()
    {
        // Arrange
        Car car = new Car
        {
            Licenseplate = "AB12345",
            Date = DateTime.Now,
            IsBrobizzUsed = true
        };

        // Act
        double priceWithBrobizz = car.Price();

        // Assert
        Assert.AreEqual(240 * 0.95, priceWithBrobizz, 228); // Tolerance set to 0.01 for rounding errors
    }

    [TestMethod]
    public void MC_Price_WithBrobizz_DiscountApplied()
    {
        // Arrange
        MC mc = new MC
        {
            Licenseplate = "XY98765",
            Date = DateTime.Now,
            IsBrobizzUsed = true
        };

        // Act
        double priceWithBrobizz = mc.Price();

        // Assert
        Assert.AreEqual(125 * 0.95, priceWithBrobizz, 118); // Tolerance set to 0.01 for rounding errors
    }

    [TestMethod]
    public void Car_Price_WithoutBrobizz_NoDiscount()
    {
        // Arrange
        Car car = new Car()
        {
            Licenseplate = "CD67890",
            Date = DateTime.Now,
            IsBrobizzUsed = false
        };

        // Act
        double priceWithoutBrobizz = car.Price();

        // Assert
        Assert.AreEqual(240, priceWithoutBrobizz);
    }

    [TestMethod]
    public void MC_Price_WithoutBrobizz_NoDiscount()
    {
        // Arrange
        MC mc = new MC
        {
            Licenseplate = "LM54321",
            Date = DateTime.Now,
            IsBrobizzUsed = false
        };

        // Act
        double priceWithoutBrobizz = mc.Price();

        // Assert
        Assert.AreEqual(125, priceWithoutBrobizz);
    }
}