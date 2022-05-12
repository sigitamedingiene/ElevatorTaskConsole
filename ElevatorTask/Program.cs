using BussnesClass;
using Repository;
using Service;
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

            ElevatorMovment elevatorMovement = new ElevatorMovment(elevator);
            elevatorMovement.ElevatorMoving();
        }
    }
}
