using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnesClass
{
    public class Elevator
    {
        public string Id { get; }
        public int MaxCapacityKg { get; }
        public int ElevatorPlace { get; }

        public Elevator(string id, int maxCapacityKg, int elevatorPlace)
        {
            Id = id;
            MaxCapacityKg = maxCapacityKg;
            ElevatorPlace = elevatorPlace;
        }

        public bool ElevatorMoves(int peopleCapacityKg, int floorNumber)
        {
            if (peopleCapacityKg > MaxCapacityKg)
            {
                Console.WriteLine($"Elevator can't move, your are to many. Capacity must not be greater than {MaxCapacityKg}");
                return false;
            }
            else if (floorNumber == ElevatorPlace)
            {
                Console.WriteLine("Elevator stays in the same place");
                return false;

            }
            else if (floorNumber < ElevatorPlace)
            {
                Console.WriteLine("Elevator goes down");
                return true;

            }
            else
            {
                Console.WriteLine("Elevator goes up");
                return true;
            }

        }

        public void FloorElevatorStops(int floorNumberElevatorGoesTo)
        {
            int floorElevatorStoped =  floorNumberElevatorGoesTo - ElevatorPlace;
            Console.WriteLine(floorElevatorStoped);
            
        }
    }
}
