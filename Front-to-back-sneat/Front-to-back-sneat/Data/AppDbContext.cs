using Front_to_back_sneat.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back_sneat.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }

        public DbSet<SliderImage> SliderImages { get; set; }

        public DbSet<Work> Works { get; set; }

        public DbSet<Service> Services { get; set; }
    }
}
