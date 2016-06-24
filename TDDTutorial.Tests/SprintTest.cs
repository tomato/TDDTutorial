using System;
using NUnit.Framework;
using TDDTutorial.Models;

namespace TDDTutorial.Tests
{
    [TestFixture]
    public class SprintTest
    {
        [Test]
        public void Profit_ShouldShow200PercentWhenRevenueIsTwiceCost()
        {
            //Arrange
            var sprint = new Sprint() { Revenue = 10, Cost = 5 };

            //Act

            //Assert
            Assert.AreEqual(200, sprint.Profit);
        }

        [Test]
        public void Profit_ShouldShow0WhenCostIsZero()
        {
            var sprint = new Sprint() { Revenue = 10, Cost = 0 };

            Assert.AreEqual(0, sprint.Profit);
        }

        [Test]
        public void Profit_ShouldShowCorrectPercentageWhenRatioIsNotWholeNumber()
        {
            var sprint = new Sprint() { Revenue = 15, Cost = 10 };

            Assert.AreEqual(150, sprint.Profit);

            sprint = new Sprint() { Revenue = 5, Cost = 10 };

            Assert.AreEqual(50, sprint.Profit);
        }
    }
}
