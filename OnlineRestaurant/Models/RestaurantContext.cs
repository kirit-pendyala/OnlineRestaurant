using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OnlineRestaurant.Models
{
    public partial class RestaurantContext : DbContext
    {
       

        public RestaurantContext(DbContextOptions<RestaurantContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dessert> Dessert { get; set; }
        public virtual DbSet<Dishes> Dishes { get; set; }
        public virtual DbSet<MainCourse> MainCourse { get; set; }
        public virtual DbSet<Restaurants> Restaurants { get; set; }
        public virtual DbSet<Starter> Starter { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=Restaurant;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dessert>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Dcalories)
                    .HasColumnName("DCalories")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dishes>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Calories).HasColumnName("calories");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<MainCourse>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Mcalories).HasColumnName("MCalories");

                entity.Property(e => e.Mname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Restaurants>(entity =>
            {
                entity.Property(e => e.CustomerEmail).IsRequired();

                entity.Property(e => e.CustomerMobile)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CustomerName).IsRequired();
            });

            modelBuilder.Entity<Starter>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Scalories).HasColumnName("SCalories");

                entity.Property(e => e.Sname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
