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
                // entity.HasKey(e => e.StoreNumber)
                //     .HasName("PK__stores__0BBE57CCD22ABEEB");

                entity.ToTable("Stores");

                entity.Property(e => e.LocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("LocationId");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                
            });

		}

		
	}
}