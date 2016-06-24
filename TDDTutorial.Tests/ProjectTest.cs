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
        public void TotalRevenue_ShouldShowASumOfCompletedRevenue()
        {
            var project = new Project()
            {
                Sprints = new List<Sprint>() {
                    new Sprint() { Revenue = 2, IsCompleted = true },
                    new Sprint() { Revenue = 3, IsCompleted = true },
                    new Sprint() { Revenue = 4, IsCompleted = false }
                }
            };

            Assert.AreEqual(5, project.TotalRevenue());
        }

        [Test]
        public void TotalCost_ShouldShowASumOfCompletedCost()
        {
            var project = new Project()
            {
                Sprints = new List<Sprint>() {
                    new Sprint() { Cost = 2, IsCompleted = true },
                    new Sprint() { Cost = 3, IsCompleted = true },
                    new Sprint() { Cost = 4, IsCompleted = false }
                }
            };

            Assert.AreEqual(5, project.TotalCost());
        }

        [Test]
        public void TotalRevenue_Should0IfNoSprints()
        {
            var project = new Project();

            Assert.AreEqual(0, project.TotalRevenue());
        }
    }
}
