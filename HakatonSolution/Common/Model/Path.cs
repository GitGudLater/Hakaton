using BLL.Implementations.DataAccess.BindingEntities;
using System.Collections.Generic;

namespace Common.Model
{
    public class Path
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WeekGraphicId { get; set; }

        public string CoordStart { get; set; }
        public string CoordFin { get; set; }
        public string TBegin { get; set; }

        public int MaxSeads { get; set; }

        public string Description { get; set; }

        public ICollection<PathUserBinding> PathUserBindings { get; set; }

        public Path()
        {
            PathUserBindings = new List<PathUserBinding>();
        }
    }
}
