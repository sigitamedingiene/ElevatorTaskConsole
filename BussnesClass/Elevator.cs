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
        public int MaxCapacity { get; }
        public int ElevatorPlace { get; }

        public Elevator(string id, int maxCapacity, int elevatorPlace)
        {
            Id = id;
            MaxCapacity = maxCapacity;
            ElevatorPlace = elevatorPlace;
        }

        public bool ElevatorMoves(int peopleCapacity, int floorNumberPeopleWhantToGo, int elevatorPalceFloor)
        {
            if (peopleCapacity > MaxCapacity)
            {
                Console.WriteLine($"Elevator can't move, your are to many. Capacity must not be greater than {MaxCapacity}");
                return false;
            }
            else if (floorNumberPeopleWhantToGo == elevatorPalceFloor)
            {
                Console.WriteLine("Elevator stays in the same place, choose another floor");
                return true;

            }
            else if (floorNumberPeopleWhantToGo < elevatorPalceFloor)
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
            Console.WriteLine(floorNumberElevatorGoesTo);
            
        }
    }
}
