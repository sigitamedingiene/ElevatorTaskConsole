using BussnesClass;
using Repository;
using System;

namespace ElevatorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BuildingRepository buldingList = new BuildingRepository();
            ElevatorRepository elevatorList = new ElevatorRepository();

            buldingList.GetBuildingData();
            Building building = new Building(buldingList.BuildingAdress, buldingList.FloorCount, buldingList.ElevatorStandsInWichFloor, buldingList.ElevatorId);
            elevatorList.GetElevatorData();
            Elevator elevator = new Elevator(elevatorList.ElevatorId, elevatorList.MaxCapacity, elevatorList.ElevatorStayingFloor);

            Console.WriteLine("Write how many people in kg want to use the elevator.");
            int peopleCapacityInKg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write in wich floor you want to go.");
            int floorNumber = Convert.ToInt32(Console.ReadLine());

            elevator.ElevatorMoves(peopleCapacityInKg, floorNumber);
            Console.WriteLine("Elevator stops in:");
            elevator.FloorElevatorStops(floorNumber);
        }
    }
}
