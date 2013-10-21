using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrossApp.Data.Models
{
    public class Idea
    {
        public Idea(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
        public List<Fact> Facts;
        public DateTime CreatedAt { get; set; }
        public bool Rejected { get; set; }
    }
}
