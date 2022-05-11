using BussnesClass;
using System;

namespace Repository
{
    public class BuildingRepository
    {
        public string BuildingAdress;
        public int FloorCount;
        public int ElevatorStandsInWichFloor;
        public int ElevatorId;
        public void GetBuildingData()
        {
            Console.WriteLine("Write building adress.");
            BuildingAdress = Console.ReadLine().ToString();
            Console.WriteLine("How many floors are in the building?");
            FloorCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the last floor?");
            ElevatorStandsInWichFloor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elevator door ID is?");
            ElevatorStandsInWichFloor = Convert.ToInt32(Console.ReadLine());

            Building building = new Building(BuildingAdress, FloorCount, ElevatorStandsInWichFloor, ElevatorId);

        }
    }
}
