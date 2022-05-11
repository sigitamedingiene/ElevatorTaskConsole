using BussnesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest
{
    public class ElevatorTest
    {
        [Fact]
        public void Elevator_IsNotMoving_CapacityIsToBig()
        {
            Elevator elevator = new Elevator("A101", 500, 3);
            Assert.False(elevator.ElevatorMoves(600, 2));

        }

        [Fact]
        public void Elevator_IsMoving_CapacityIsGood()
        {
            Elevator elevator = new Elevator("A101", 500, 3);
            Assert.True(elevator.ElevatorMoves(400, 2));

        }
    }
}
