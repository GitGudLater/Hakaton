using System.Collections.Generic;
using BLL.Implementations.DataAccess;
using BLL.Interfaces;
using Common.Model;

namespace BLL.Implementations
{
    public class PathService : IPathService
    {
        private FullContext _db;

        public PathService(FullContext db)
        {
            _db = db;
        }

        public void Delete(int id)
        {
            Path path = GetById(id);

            if (path != null)
            {
                _db.Pathes.Remove(path);
            }

            _db.SaveChangesAsync();
        }

        public IEnumerable<Path> GetAll()
        {
            return _db.Pathes;
        }

        public Path GetById(int id)
        {
            Path path = null;
            foreach (var item in _db.Pathes)
            {
                if (item.Id == id)
                {
                    path = item;
                    break;
                }
            }

            return path;
        }

        public void Post(Path item)
        {
            _db.Pathes.Add(item);

            _db.SaveChangesAsync();
        }

        public void Put(Path item)
        {
            Path path = GetById(item.Id);
            if (path != null)
            {
                path.Description = item.Description;
                path.MaxSeads = item.MaxSeads;
                path.NCoordEnd = item.NCoordEnd;
                path.NCoordStart = item.NCoordStart;
                path.OccupiedSeads = item.OccupiedSeads;
                path.StartTime = item.StartTime;
                path.UserId = item.UserId;
                path.WCoordEnd = item.WCoordEnd;
                path.WCoordStart = item.WCoordStart;
                path.WeekGraphicId = item.WeekGraphicId;

                _db.SaveChangesAsync();
            }
        }
    }
}
