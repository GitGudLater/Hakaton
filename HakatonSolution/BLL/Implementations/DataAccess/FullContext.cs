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
    }
}
