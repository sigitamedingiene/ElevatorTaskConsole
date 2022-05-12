using BussnesClass;
using System;
using System.Threading;

namespace Service
{
    public class ElevatorMovment: IElevator

    {   private readonly Elevator _elevator;
        public ElevatorMovment(Elevator elevator)
        {
            _elevator = elevator;
        }
        public void ElevatorMoves()
        {
            throw new NotImplementedException();
        }
        public void FloorElevatorStop()
        {
            throw new NotImplementedException();
        }
        public void ElevatorMoving()
        {
            int elevatorPlaceFloor = _elevator.ElevatorPlace;
            while (true)
            {                
                Console.WriteLine("\r\n Write how many people in kg want to use the elevator.");
                int peopleCapacity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Write in wich floor you want to go.");
                int floorNumber = Convert.ToInt32(Console.ReadLine());

                _elevator.ElevatorMoves(peopleCapacity, floorNumber, elevatorPlaceFloor);
                int milliseconds = 2000;
                if (elevatorPlaceFloor < floorNumber)
                {
                    for (int i = elevatorPlaceFloor; i < floorNumber; i++)
                    {
                        Console.WriteLine($"Elevator is {i} floor");
                        Thread.Sleep(milliseconds);
                    }
                }
                else
                {
                    for (int i = elevatorPlaceFloor; i < floorNumber; i--)
                    {
                        Console.WriteLine($"Elevator is {i} floor");
                        Thread.Sleep(milliseconds);
                    }

                }
                Console.WriteLine("Elevator stops in:");
                _elevator.FloorElevatorStops(floorNumber);
                Console.WriteLine("Doors opens.");
                Console.WriteLine("Doors closes.");
                elevatorPlaceFloor = floorNumber;
                

            }
            
        }
    }
}
