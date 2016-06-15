using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDDTutorial.Models
{
    public class Project
    {
        private IEnumerable<Sprint> CompletedSprints
        {
            get { return Sprints.Where(x => x.IsComplete); }
        }

        public Project()
        {
            Sprints = new List<Sprint>();
        }

        public object Cost
        {
            get { return CompletedSprints.Sum(s => s.Cost); }
        }

        public int Revenue
        {
            get { return CompletedSprints.Sum(s => s.Revenue); }
        }
        public IEnumerable<Sprint> Sprints { get; set; }
    }
}