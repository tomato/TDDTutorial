using System;
using NUnit.Framework;
using TDDTutorial.Models;

namespace TDDTutorial.Tests
{
    [TestFixture]
    public class SprintTest
    {
        [Test]
        public void Profit_ShouldShow200PercentIfRevenueIsTwiceCost()
        {
            //Arrange
            var sprint = new Sprint() { Cost = 10, Revenue = 20 };
            //Act

            //Assert
            Assert.AreEqual(200, sprint.Profit);

        }


        [Test]
        public void Profit_ShouldShow0PercentIfCostIsZero()
        {
            //Arrange
            var sprint = new Sprint() { Cost = 0, Revenue = 20 };
            //Act

            //Assert
            Assert.AreEqual(0, sprint.Profit);

        }

        [Test]
        public void Profit_ShouldShowCorrectPercentageIfRatioIsNotWholeNumber()
        {
            var sprint = new Sprint() { Cost = 20, Revenue = 15 };
            //Act

            //Assert
            Assert.AreEqual(75, sprint.Profit);
        }


    }
}
