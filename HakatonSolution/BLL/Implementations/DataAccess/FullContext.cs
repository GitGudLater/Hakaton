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

        private void InstallPassengerPathRefBinding(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PassengerPathRefPathUserBinding>()
                .HasKey(t => new { t.PassengerPathRefId, t.PathId });

            modelBuilder.Entity<PassengerPathRefPathUserBinding>()
                .HasOne(sc => sc.PassengerPathRef)
                .WithMany(s => s.PassengerPathRefPathUserBindings)
                .HasForeignKey(sc => sc.PathId);

            modelBuilder.Entity<PassengerPathRefPathUserBinding>()
                .HasOne(sc => sc.PassengerPathRef)
                .WithMany(s => s.PassengerPathRefPathUserBindings)
                .HasForeignKey(sc => sc.UserId);
        }
    }
}
