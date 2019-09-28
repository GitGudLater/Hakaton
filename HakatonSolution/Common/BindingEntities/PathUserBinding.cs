using Common.Model;

namespace BLL.Implementations.DataAccess.BindingEntities
{
    public class PathUserBinding
    {
        public int PathId { get; set; }
        public Path Path { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
