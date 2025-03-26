using HMS.Models;
using Microsoft.EntityFrameworkCore;

namespace HMS.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options) { }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Hotel -> Manager (1:1)
            modelBuilder.Entity<Hotel>()
                .HasOne(h => h.Manager)
                .WithOne(m => m.Hotel)
                .HasForeignKey<Manager>(m => m.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            // Hotel -> Rooms (1:M)
            modelBuilder.Entity<Hotel>()
                .HasMany(h => h.Rooms)
                .WithOne(r => r.Hotel)
                .HasForeignKey(r => r.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            // Room -> Reservations (1:M)
            modelBuilder.Entity<Room>()
                .HasMany(r => r.Reservations)
                .WithOne(res => res.Room)
                .HasForeignKey(res => res.RoomId)
                .OnDelete(DeleteBehavior.Cascade);

            // Guest -> Reservations (1:M)
            modelBuilder.Entity<Guest>()
                .HasMany(g => g.Reservations)
                .WithOne(res => res.Guest)
                .HasForeignKey(res => res.GuestId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
