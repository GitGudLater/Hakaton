using BLL.Implementations.DataAccess.BindingEntities;
using Common.Model;
using Microsoft.EntityFrameworkCore;

namespace BLL.Implementations.DataAccess
{
    public class FullContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Path> Pathes { get; set; }
        public DbSet<PassengerPathRef> PassengerPathRefs { get; set; }
        public DbSet<WeekGraphicDb> WeekGraphics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            InstallPathUserBinding(modelBuilder);
        }

        private void InstallPathUserBinding(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PathUserBinding>()
                .HasKey(t => new { t.PathId, t.UserId });

            modelBuilder.Entity<PathUserBinding>()
                .HasOne(sc => sc.Path)
                .WithMany(s => s.PathUserBindings)
                .HasForeignKey(sc => sc.PathId);
        }

        private void InstallPassengerPathRefPathBinding(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PassengerPathRefPathBinding>()
                .HasKey(t => new { t.PassengerPathRefId, t.PathId });

            modelBuilder.Entity<PassengerPathRefPathBinding>()
                .HasOne(sc => sc.PassengerPathRef)
                .WithMany(s => s.PassengerPathRefPathBindings)
                .HasForeignKey(sc => sc.PathId);
        }

        private void PassengerPathRefUserBinding(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PassengerPathRefUserBinding>()
                .HasKey(t => new { t.PassengerPathRefId, t.UserId });

            modelBuilder.Entity<PassengerPathRefUserBinding>()
                .HasOne(sc => sc.PassengerPathRef)
                .WithMany(s => s.PassengerPathRefUserBindings)
                .HasForeignKey(sc => sc.UserId);
        }
    }
}
