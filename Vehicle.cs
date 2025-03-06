namespace ParkingSystem

public enum VehicleType { Car, Motorcycle }

public class Vehicle
{
    public string LicensePlate { get; set; }
    public VehicleType Type { get; set; }
    public string Color { get; set; }

    public Vehicle(string lisencePlate, VehicleType type, string color)
    {
        LicensePlate = LicensePlate;
        Type = type;
        Color = color;
    }
}
