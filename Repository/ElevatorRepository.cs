using BussnesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ElevatorRepository
    {
        public string ElevatorId;
        public int MaxCapacity;
        public int ElevatorStayingFloor;
        public void GetElevatorData()
        {
            Console.WriteLine("Write Elevator ID.");
            ElevatorId = Console.ReadLine().ToString();
            Console.WriteLine("Write Max Capacity of the Elevator.");
            MaxCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In wich floor Elevator is?");
            ElevatorStayingFloor = Convert.ToInt32(Console.ReadLine());

            Elevator elevator = new Elevator(ElevatorId, MaxCapacity, ElevatorStayingFloor);
        }
    }
}
