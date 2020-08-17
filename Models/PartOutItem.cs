using System;
using System.Collections.Generic;

namespace PartOut.Models
{
    public class PartOutItem
    {

        public long Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string Description { get; set; }

        public DateTime PostDate { get; set; } = DateTime.Now;

        public List<Detail> Details { get; set; } = new List<Detail>();

    }
}
