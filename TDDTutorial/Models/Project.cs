using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDDTutorial.Models
{
    public class Project
    {

        public IEnumerable<Sprint> Sprints { get; set; } = new List<Sprint>();

        public IEnumerable<Sprint> CompletedSprints
        {
            get { return Sprints.Where(s => s.IsCompleted); }
        }

        public double TotalRevenue()
        {
            return CompletedSprints.Sum(s => s.Revenue);
        }

        public double TotalCost()
        {
            return CompletedSprints.Sum(s => s.Cost);
        }
    }
}