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
        public void TotalRevenue_ShouldShowSumOfCompletedSprintRevenues()
        {
            var project = new Project()
            {
                Sprints = new List<Sprint>() {
                    new Sprint() { IsCompleted = true, Revenue = 40 },
                    new Sprint() { IsCompleted = true, Revenue = 100 },
                    new Sprint() { IsCompleted = false, Revenue = 3 }
                }
            };

            Assert.AreEqual(140, project.TotalRevenue());

        }

        [Test]
        public void TotalRevenue_ShouldShow0IfThereAreNoSprints()
        {
            var project = new Project();

            Assert.AreEqual(0, project.TotalRevenue());

        }

        [Test]
        public void TotalCost_ShouldShowSumOfCompletedSprintCost()
        {
            var project = new Project()
            {
                Sprints = new List<Sprint>() {
                    new Sprint() { IsCompleted = true, Cost = 40 },
                    new Sprint() { IsCompleted = true, Cost = 100 },
                    new Sprint() { IsCompleted = false, Cost = 3 }
                }
            };

            Assert.AreEqual(140, project.TotalCost());

        }


    }
}
