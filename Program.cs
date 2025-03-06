using System;

namespace ParkingSystem
{
    class Program
    {
        static void Main()
        {
            ParkingLot parkingLot = null;
            while(true){
                string input = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(input)) continue;

                string[] args = input.Split(' ');
                string command = args[0].ToLower();

                switch(command){
                    case "create_parking_lot":
                        parkingLot = new ParkingLot(int.Parse(args[1]));
                        break;
                    case "park":
                        parkingLot?.Park(new Vehicle(args[1], Enum.Parse<VehicleType>(args[3], true), args[2]));
                        break;
                    case "leave":
                        parkingLot?.Leave(int.Parse(args[1]));
                        break;
                    case "status":
                        parkingLot?.Status();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }
        }
    }
}
