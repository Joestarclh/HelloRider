using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
namespace HelloRider.Tests
{
    [TestClass]
    public class DeskFanTests
    {
        [TestMethod]
        public void PowerLowerTanZero_OK()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 0);
            var fan = new DeskFan(mock.Object);
            
            var expected = "won't work";
            var actual = fan.Work();
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void PowerHigherThan200_Waring()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 220);

            var fan = new DeskFan(mock.Object);
            var expected = "Warnng";
            var actual = fan.Work();
            Assert.AreEqual(expected, actual);
        }
    }


}
