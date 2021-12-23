using initialback.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initialback.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }
        public DbSet<Sliderimage> SliderImages { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Icon> Icons { get; set; }
        public DbSet<Florish> Florishes { get; set; }
        public DbSet<FlorishType> FlorishType { get; set; }
    }
}
