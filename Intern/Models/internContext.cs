using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Intern.Models
{
    public partial class internContext : DbContext
    {
        public internContext()
        {
        }

        public internContext(DbContextOptions<internContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DashBoard> DashBoards { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<PromotionAll> PromotionAlls { get; set; }
        public virtual DbSet<PromotionCollection> PromotionCollections { get; set; }
        public virtual DbSet<PromotionStore> PromotionStores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-8NLVOET;Database=intern;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.PhoneNo);

                entity.ToTable("Customer");

                entity.Property(e => e.PhoneNo)
                    .ValueGeneratedNever()
                    .HasColumnName("Phone no");

                entity.Property(e => e.DayOfRedemption)
                    .HasColumnType("date")
                    .HasColumnName("Day of Redemption");

                entity.Property(e => e.Gift)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Redemtioncode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Store)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<DashBoard>(entity =>
            {
                entity.ToTable("DashBoard");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.RedeemForProduct)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Redeem for Product");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Store)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductName);

                entity.ToTable("Product");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ImportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Import Date");

                entity.Property(e => e.Inventory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SKU");

                entity.HasOne(d => d.InventoryNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Inventory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Promotion_collection");
            });

            modelBuilder.Entity<PromotionAll>(entity =>
            {
                entity.HasKey(e => e.Campaign);

                entity.ToTable("Promotion_all");

                entity.Property(e => e.Campaign).HasMaxLength(100);

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("End date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("Start date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PromotionCollection>(entity =>
            {
                entity.HasKey(e => e.Inventory);

                entity.ToTable("Promotion_collection");

                entity.Property(e => e.Inventory)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Campaign)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CollectionName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Collection name");

                entity.Property(e => e.TotalOfProduct)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Total of product")
                    .IsFixedLength(true);

                entity.HasOne(d => d.CampaignNavigation)
                    .WithMany(p => p.PromotionCollections)
                    .HasForeignKey(d => d.Campaign)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Promotion_collection_Promotion_all");
            });

            modelBuilder.Entity<PromotionStore>(entity =>
            {
                entity.HasKey(e => e.StoreName);

                entity.ToTable("Promotion_store");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(200)
                    .HasColumnName("Store name");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InCapaign)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("In capaign");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
