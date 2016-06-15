using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TDDTutorial.Models;

namespace TDDTutorial.Data
{
    public class DataContext
    {
        public IEnumerable<Sprint> GetSprints()
        {
            return new List<Sprint>() {
                new Sprint() { Id=1, Cost=5000, Revenue=8000 },
                new Sprint() { Id=2, Cost=4500, Revenue=300 },
                new Sprint() { Id=3, Cost=5200, Revenue=20000 }
            };
        }

        public Project GetProject()
        {
            return new Project()
            {
                Sprints = GetSprints()
            };
        }
    }
}