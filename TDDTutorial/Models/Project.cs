using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDDTutorial.Models
{
    public class Project
    {
        public IEnumerable<Sprint> Sprints { get; set; }
    }
}