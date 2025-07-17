using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL.EF.Context
{
    public partial class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Diagnostic> Diagnostics { get; set; }
        public DbSet<Nutrient> Nutrients { get; set; }
        public DbSet<NutrientConsumption> NutrientConsumptions { get; set; }
        public DbSet<Recomdendation> Recomdendations { get; set; }
        public DbSet<PersonalSuggestion> PersonalSuggestions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<NutrientContains> NutrientContains { get; set; }

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Product>(b =>
			{
				b.HasMany(u => u.PersonalSuggestions)
					.WithMany(x => x.Products)
					.UsingEntity<ProductPersonalSuggestion>();
			});

			base.OnModelCreating(modelBuilder);
        }
    }
}
