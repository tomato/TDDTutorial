using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDDTutorial.Models
{
    public class Project
    {

        public IEnumerable<Sprint> Sprints { get; set; } = new List<Sprint>();

        private IEnumerable<Sprint> CompletedSprints
        {
            get { return Sprints.Where(s => s.IsCompleted);  }
        }

        public int TotalRevenue() {
                return CompletedSprints.Sum(s => s.Revenue);
        }

        public int TotalCost()
        {
            return CompletedSprints.Sum(s => s.Cost);
        }
    }
}