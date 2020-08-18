using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PartOut.Models
{
    public class PartOutItem
    {

        public long Id { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }

        public string Description { get; set; }

        public DateTime PostDate { get; set; } = DateTime.Now;

        public List<Detail> Details { get; set; } = new List<Detail>();


    }

    public class Detail
    {

        public long Id { get; set; }

        public string Description { get; set; }

        public PartOutItem PartOutItem { get; set; }
    }
}
