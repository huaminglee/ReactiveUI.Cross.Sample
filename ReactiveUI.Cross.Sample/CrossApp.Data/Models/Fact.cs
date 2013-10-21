using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrossApp.Data.Models
{
    public class Fact
    {
        public Fact(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
        public bool Weakness { get; set; }
        public int Weight { get; set; }
        public int VotesImportant { get; set; }
        public int VotesNonsense { get; set; }
    }
}
