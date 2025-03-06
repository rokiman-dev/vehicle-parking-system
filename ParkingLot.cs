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

    public void Leave(int slotNumber){
        var slot = slots.FirstOrDefualt(s => s.SlotNumber ==  slotNumber);
        if(slot?.ParkedVehicle != null){
            Console.WriteLine($"Slot {slot.SlotNumber} is now free");
            slot.ParkedVehicle = null;
        }else{
            Console.WriteLine("Slot is already empty.");
        }
    }

    public void Status(){
        Console.WriteLine("Slot\tLicensePlate\tType\tColor");
        foreach(var slot in slots.Where(s => s.ParkedVehicle != null)){
            Console.WriteLine($"{slot.SlotNumber}\t{slot.ParkedVehicle.lisencePlate}\t{slot.ParkedVehicle.Type}\t{slot.ParkedVehicle.color}");
        }
    }
}