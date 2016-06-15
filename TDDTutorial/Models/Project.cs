using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDDTutorial.Models
{
    public class Project
    {
        public Project()
        {
            Sprints = new List<Sprint>();
        }

        public int Revenue
        {
            get { return Sprints.Sum(s => s.Revenue); }
        }
        public IEnumerable<Sprint> Sprints { get; set; }
    }
}