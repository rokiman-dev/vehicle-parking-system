using System;

namespace ParkingSystem{
    public enum VehicleType { Car, Motorcycle }
    public class Vehicle
{
    public string LicensePlate { get; set; }
    public VehicleType Type { get; set; }
    public string Color { get; set; }
    public DateTime CheckInTime {get; set;}

    public Vehicle(string licensePlate, VehicleType type, string color)
    {
        LicensePlate = licensePlate;
        Type = type;
        Color = color;
        CheckInTime = DateTime.Now;
    }
}
}

