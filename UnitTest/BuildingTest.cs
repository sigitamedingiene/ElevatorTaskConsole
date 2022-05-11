using BussnesClass;
using System;
using Xunit;

namespace UnitTest
{
    public class BuildingTest
    {
        [Fact]
        public void BuildingTest_FloorNumberInvalid()
        {
            Building building = new Building("Ruko str.", 25, -2, 508);
            Assert.False(building.IsFloorCountValid(27));
        }

        [Fact]
        public void BuildingTest_FloorNumberInValid()
        {
            Building building = new Building("Ruko str.", 25, -2, 508);
            Assert.False(building.IsFloorCountValid(-4));
        }
    }
}
