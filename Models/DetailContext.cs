using System;
using Microsoft.EntityFrameworkCore;

namespace PartOut.Models
{
    public class DetailContext : DbContext
    {
        public DetailContext(DbContextOptions<DetailContext> options)
            :base(options)
        {

        }
        public DbSet<Detail> Details { get; set; }
    }
}
