using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Library.Entities
{
    public partial class projectZeroContext : DbContext
    {
        public projectZeroContext()
        {
        }

        public projectZeroContext(DbContextOptions<projectZeroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<CustomerOrder> CustomerOrders { get; set; }
        public virtual DbSet<StoreLocation> StoreLocation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=tcp:2020-revature-pflug.database.windows.net,1433;Initial Catalog=projectZero;Persist Security Info=False;User ID=jack;Password= Bluefridge122;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.FullName })
                    .HasName("PK__Customer__58252831281712D4");

                entity.HasIndex(e => e.FullName)
                    .HasName("UQ__Customer__C8B4CE9F67261C58")
                    .IsUnique();

                entity.Property(e => e.CustomerId).ValueGeneratedOnAdd();

                entity.Property(e => e.FullName)
                    .HasColumnName("fullName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StoreLocation)
                    .HasColumnName("storeLocation")
                    .HasMaxLength(30);

                entity.HasOne(d => d.StoreLocationNavigation)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.StoreLocation)
                    .HasConstraintName("FK__Customer__storeL__44CA3770");
            });

            modelBuilder.Entity<CustomerOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__customer__C3905BCF42E788D6");

                entity.ToTable("customerOrder");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LocationName).HasMaxLength(30);

                entity.Property(e => e.ProductName).HasMaxLength(30);

                entity.HasOne(d => d.CustomerNameNavigation)
                    .WithMany(p => p.CustomerOrder)
                    .HasPrincipalKey(p => p.FullName)
                    .HasForeignKey(d => d.CustomerName)
                    .HasConstraintName("FK__customerO__Custo__4E53A1AA");

                entity.HasOne(d => d.LocationNameNavigation)
                    .WithMany(p => p.CustomerOrder)
                    .HasForeignKey(d => d.LocationName)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__customerO__Locat__4D5F7D71");

                entity.HasOne(d => d.ProductNameNavigation)
                    .WithMany(p => p.CustomerOrder)
                    .HasPrincipalKey(p => p.ProductName)
                    .HasForeignKey(d => d.ProductName)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__customerO__Produ__4C6B5938");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__OrderIte__B40CC6CD8AA5F42D");

                entity.HasIndex(e => e.ProductName)
                    .HasName("UQ__OrderIte__DD5A978ABDA3D64B")
                    .IsUnique();

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<StoreLocation>(entity =>
            {
                entity.HasKey(e => e.LocationName)
                    .HasName("PK__storeLoc__F946BB858C9A7FA6");

                entity.ToTable("storeLocation");

                entity.Property(e => e.LocationName).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
