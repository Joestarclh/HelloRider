using System;
using Xunit;


namespace HelloRider.Tests
{
    public class DeskFanTests
    {
        [Fact]
        public void PowerLowerThanZero_OK()
        {
            var fan = new DeskFanTests(new PowerSupplyLowerThanZero());
            var expected = "Won't work.";
            var actual = fan.Work();
            Assert.Equal((expected.actual));
            
        }
    }

    class PowerSupplyLowerThanZero: IPowerSupply
    {
        public int GetPower()
        {
            return 0;
        }
    }
}