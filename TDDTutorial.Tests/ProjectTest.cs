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
                    new Sprint() { Revenue = 123 },
                    new Sprint() { Revenue = 1 }
                }
            };

            //Act
            var revenue = project.Revenue;

            //Assert
            Assert.AreEqual(124, revenue);
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
