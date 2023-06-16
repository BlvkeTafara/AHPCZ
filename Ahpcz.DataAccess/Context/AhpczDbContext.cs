using Ahpcz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahpcz.DataAccess.Context
{
    public class AhpczDbContext : DbContext
    {
        public AhpczDbContext(DbContextOptions<AhpczDbContext> options) : base(options) { }

        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Province> Provinces { get; set; }

    }
    
}
