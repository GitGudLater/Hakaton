using System.Collections.Generic;
using BLL.Implementations.DataAccess;
using BLL.Interfaces;
using Common.JsonModels;
using Common.Model;

namespace BLL.Implementations
{
    public class PathService : IPathService
    {
        private FullContext _db;
        private WeekGraphicService _weekGraphicService;
        private UserService _userService;
        private PassengerPathRefService _passengerPassRefService;

        public PathService(FullContext db, 
            WeekGraphicService weekGraphicService, 
            UserService userService,
            PassengerPathRefService passengerPassRefService)
        {
            _db = db;
            _weekGraphicService = weekGraphicService;
            _userService = userService;
            _passengerPassRefService = passengerPassRefService;
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
                path.CoordStart = item.CoordStart;
                path.TBegin = item.TBegin;
                path.UserId = item.UserId;
                path.CoordFin = item.CoordFin;
                path.WeekGraphicId = item.WeekGraphicId;

                _db.SaveChangesAsync();
            }
        }

        public JsonPath GetJsonPath(int pathId)
        {
            JsonPath result = new JsonPath();

            Path path = GetById(pathId);
            User user = _userService.GetById(path.UserId);
            WeekGraphic graph = _weekGraphicService.GetById(path.WeekGraphicId);
            
            List<PassengerPathRef> passengers = _passengerPassRefService.GetPassengersList(pathId);

            result.Car = user.Car;
            result.Days = graph.Days;
            result.Description = path.Description;
            result.EmptySeats = path.MaxSeads - passengers.Count;
            result.Id = path.Id;
            result.CoordStart = path.CoordStart;
            result.TBegin = path.TBegin;
            result.CoordFin = path.CoordFin;
            result.CoordStart = path.CoordStart;

            return result;
        }
    }
}
