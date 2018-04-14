namespace Dz_4_AdoNet
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SellingModel : DbContext
    {
        public SellingModel()
            : base("name=SellingModel1")
        {
        }

        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buyer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Buyer>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Buyer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Buyer)
                .HasForeignKey(e => e.Buyers_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Seller>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Seller>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Seller>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Seller)
                .HasForeignKey(e => e.Sellers_id)
                .WillCascadeOnDelete(false);
        }
    }
}
