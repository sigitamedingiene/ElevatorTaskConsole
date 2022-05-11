using System;

namespace BussnesClass
{
    public class Building
    {
        public string Adress { get; }
        public int FloorCount { get; }
        public int FinalFloor { get; }
        public int ElevatorDoorId { get; }


        public Building(string adress, int floorCount, int finalFloor, int elevatorDoorId)
        {
            Adress = adress;
            FloorCount = floorCount;
            FinalFloor = finalFloor;
            ElevatorDoorId = elevatorDoorId;

        }

        public bool IsFloorCountValid(int floor)
        {
            if (floor < FloorCount || floor > FinalFloor)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
