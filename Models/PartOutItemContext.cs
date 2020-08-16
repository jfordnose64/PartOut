using System;
using Microsoft.EntityFrameworkCore;

namespace PartOut.Models
{
    public class PartOutItemContext : DbContext
    {
        public PartOutItemContext(DbContextOptions <PartOutItemContext> options)
            :base(options)
        {

        }
        public DbSet<PartOutItem> PartOutItems { get; set; }
    }
}
