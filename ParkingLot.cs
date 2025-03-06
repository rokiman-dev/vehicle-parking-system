using System;
using System.Collections.Generic;
using System.Linq;

public class ParkingLot
{
    private List<Slot> slots;

    public ParkingLot(int totalSlots)
    {
        slots = Enumerable.Range(1, totalSlots).Select(i => new Slot { SlotNumber = i }).ToList();
        Console.WriteLine($"Parking lot created with {totalSlots} slots.");
    }

    public void Park(Vehicle vehicle)
    {
        var availableSlot = slots.FirstOrDefualt(s => s.ParkedVehicle == null);
        if (availableSlot = null){
            Console.WriteLine("Parking is full.");
            return;
        }
        availableSlot.ParkedVehicle = vehicle;
        Console.WriteLine($"Allocated slot number: {availableSlot.SlotNumber}");
    }
}