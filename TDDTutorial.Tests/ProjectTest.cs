using System;
using NUnit.Framework;
using TDDTutorial.Models;
using System.Collections.Generic;

namespace TDDTutorial.Tests
{
    [TestFixture]
    public class ProjectTest
    {
        [Test]
        public void TotalRevenue_ShouldShowSumOfSprintRevenues()
        {
            //Arrange
            var project = new Project()
            {
                Sprints = new List<Sprint>()
                {
                    new Sprint() { Revenue = 123, IsComplete = true },
                    new Sprint() { Revenue = 1, IsComplete = true},
                    new Sprint() { Revenue = 900, IsComplete = false}
                }
            };

            //Act
            var revenue = project.Revenue;

            //Assert
            Assert.AreEqual(124, revenue);
        }

        [Test]
        public void TotalCosts_ShouldShowSumOfSprintCosts()
        {
            //Arrange
            var project = new Project()
            {
                Sprints = new List<Sprint>()
                {
                    new Sprint() { Cost = 99, IsComplete = true },
                    new Sprint() { Cost = 1, IsComplete = true },
                    new Sprint() { Cost = 1, IsComplete = false }
                }
            };

            //Act
            var cost = project.Cost;

            //Assert
            Assert.AreEqual(100, cost);
        }

        [Test]
        public void TotalRevenue_ShouldShow0IfThereAreNoSprints()
        {
            //Arrange
            var project = new Project();

            //Act
            var revenue = project.Revenue;

            //Assert
            Assert.AreEqual(0, revenue);
        }
    }
}
