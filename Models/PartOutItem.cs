using System;
namespace PartOut.Models
{
    public class PartOutItem
    {
        public long Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string Description { get; set; }

    }
}
