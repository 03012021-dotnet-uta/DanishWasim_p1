using Microsoft.EntityFrameworkCore;
using models;
// using Repository.Models;
// using Microsoft.Extensions.Configuration;

#nullable disable

namespace Repository
{
	public class memeSaverContext : DbContext
	{
		public DbSet<Person> Persons { get; set; }
	    public virtual DbSet<Inventory> Inventories { get; set; }
		public virtual DbSet<Store> Stores { get; set; }

		public DbSet<LikesJunction> LikesJunction { get; set; }

		public memeSaverContext(DbContextOptions<memeSaverContext> options) : base(options)
		{ }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// optionsBuilder.UseSqlServer(Configuration.GetConnectionString("memeDb"));
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<LikesJunction>()
				.HasKey(c => new { c.PersonId, c.MemeId });


			modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK__Stores__E7FEA497E2CA8C16");
					

                entity.ToTable("Stores");


                entity.Property(e => e.LocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("LocationId");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                
            });
			modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.InventoryId)
                    .HasName("PK__Stores__E7FEA497E2CA8C16");
					

                entity.ToTable("Inventory");


                entity.Property(e => e.StoreId)
                    .ValueGeneratedNever()
                    .HasColumnName("StoreId");

                entity.Property(e => e.Quantity)
                    .HasMaxLength(50);

				entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProductId");
                
            });
		}

		
	}
}