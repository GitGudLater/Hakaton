using BLL.Implementations.DataAccess;
using BLL.Interfaces;
using Common.Model;
using System.Collections.Generic;

namespace BLL.Implementations
{
    public class WeekGraphicService : IWeekGraphicService
    {
        private FullContext _db;

        public WeekGraphicService(FullContext db)
        {
            _db = db;
        }

        public void Delete(int id)
        {
            WeekGraphicDb graph = GetWeekGraphicDb(id);

            if (graph != null)
            {
                _db.WeekGraphics.Remove(graph);
            }

            _db.SaveChangesAsync();
        }

        public IEnumerable<WeekGraphic> GetAll()
        {
            IEnumerable<WeekGraphicDb> graphics = _db.WeekGraphics;

            List<WeekGraphic> result = new List<WeekGraphic>();
            foreach (var item in graphics)
            {
                result.Add(item.ToWeekGraphic());
            }

            return result;
        }

        public WeekGraphic GetById(int id)
        {
            WeekGraphic graph = null;
            foreach (var item in _db.WeekGraphics)
            {
                if (item.Id == id)
                {
                    graph = item.ToWeekGraphic();
                    break;
                }
            }

            return graph;
        }

        public void Post(WeekGraphic item)
        {
            _db.WeekGraphics.Add(WeekGraphicDb.ParseToDbVersion(item));

            _db.SaveChangesAsync();
        }

        public void Put(WeekGraphic item)
        {
            WeekGraphicDb graphic = GetWeekGraphicDb(item.Id);
            if (graphic != null)
            {
                graphic.Day1 = item.Days[0];
                graphic.Day2 = item.Days[1];
                graphic.Day3 = item.Days[2];
                graphic.Day4 = item.Days[3];
                graphic.Day5 = item.Days[4];
                graphic.Day6 = item.Days[5];
                graphic.Day7 = item.Days[6];
                graphic.Id = item.Id;

                _db.SaveChangesAsync();
            }
        }

        private WeekGraphicDb GetWeekGraphicDb(int id)
        {
            WeekGraphicDb graph = null;
            foreach (var item in _db.WeekGraphics)
            {
                if (item.Id == id)
                {
                    graph = item;
                    break;
                }
            }

            return graph;
        }
    }
}
