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
            var sprint = new Sprint() { Id = 1, Cost = 5, Revenue = 10 };
            Assert.AreEqual(200, sprint.Profit);
        }

        [Test]
        public void Profit_ShouldShow0ProfitIfCostIsZero()
        {
            var sprint = new Sprint() { Id = 1, Cost = 0, Revenue = 10 };
            Assert.AreEqual(0, sprint.Profit);
        }

        [Test]
        public void Profit_ShouldShowCorrectPercentageRatioIsNotWholeNumber()
        {
            var sprint = new Sprint() { Id = 1, Cost = 4, Revenue = 1 };
            Assert.AreEqual(25, sprint.Profit);

            sprint = new Sprint() { Id = 1, Cost = 2, Revenue = 3 };
            Assert.AreEqual(150, sprint.Profit);
        }
    }
}
