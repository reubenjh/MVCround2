using Microsoft.EntityFrameworkCore;
using MVCround2.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCround2.Data
{
    public class MVCround2DbContext : DbContext
    {
        public MVCround2DbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Location> Locations { get; set; }
    }
}
