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
        public DbSet<Recommendation> Recommendations { get; set; }
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
			modelBuilder.Entity<Diagnostic>(b =>
			{
				b.HasKey(x => x.Id);
				b.HasOne(x => x.User)
				 .WithMany()
				 .HasForeignKey(x => x.UserId);
			});

			modelBuilder.Entity<NutrientConsumption>(b =>
			{
				b.HasKey(x => x.Id);
				b.HasOne(x => x.Diagnostic)
				 .WithMany(x => x.NutrientConsumptions)
				 .HasForeignKey(x => x.DiagnosticId);
				b.HasOne(x => x.Nutrient)
				 .WithMany()
				 .HasForeignKey(x => x.NutrientId);
			});

			modelBuilder.Entity<Recommendation>(b =>
			{
				b.HasKey(x => x.Id);
				b.HasOne(x => x.User)
				 .WithMany(x => x.Recommendations)
				 .HasForeignKey(x => x.UserId);
				b.HasOne(x => x.Nutrient)
				 .WithMany()
				 .HasForeignKey(x => x.NutrientId);
			});

			modelBuilder.Entity<NutrientContains>(b =>
			{
				b.HasKey(x => x.Id);
				b.HasOne(x => x.Nutrient)
				 .WithMany()
				 .HasForeignKey(x => x.NutrientId);
				b.HasOne(x => x.Product)
				 .WithMany(x => x.Compound)
				 .HasForeignKey(x => x.ProductId);
			});

			modelBuilder.Entity<ProductPersonalSuggestion>(b =>
			{
				b.HasKey(x => new { x.ProductId, x.ProductSuggestionId });
				b.HasOne(x => x.Product)
				 .WithMany(x => x.ProductPersonalSuggestions)
				 .HasForeignKey(x => x.ProductId);
				b.HasOne(x => x.ProductSuggestion)
				 .WithMany(x => x.ProductPersonalSuggestions)
				 .HasForeignKey(x => x.ProductSuggestionId);
			});

			base.OnModelCreating(modelBuilder);
        }
    }
}
