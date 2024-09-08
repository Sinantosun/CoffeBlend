using CoffeBlend.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Persistance.Context
{
    public class CoffeBlendContext : DbContext
    {
        public CoffeBlendContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Galery> Galeries { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<TableDetail> TableDetails { get; set; }
    }
}
