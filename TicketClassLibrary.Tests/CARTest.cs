using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

namespace TicketClassLibrary.Tests;

[TestClass]
[TestSubject(typeof(CAR))]
public class CARTest
{

    [TestMethod]
    public void Price_ShouldReturnFixedValue()
    {
        //Jeg opretter en ny instans af CAR klassen
        var car = new CAR();
        
        //Henter Prrisen frq Price metoden
        var price = car.Price();
        
        //jeg bekræfter at prisen er 240
        Assert.AreEqual(240.0, price);
    }
    
    [TestMethod]
    public void VehicleType_ShouldReturnCar()
    {
        //Jeg opretter en ny instans af CAR klassen
        var car = new CAR();
        
        //Henter VehicleType metoden
        var vehicleType = car.VehicleType();
        
        //jeg bekræfter at vehicleType er Car
        Assert.AreEqual("Car", vehicleType);
    }
}