using BLL.Implementations.DataAccess;
using BLL.Interfaces;
using Common.Model;
using System.Collections.Generic;

namespace BLL.Implementations
{
    public class PassengerPathRefService : IPassengerPathRefService
    {
        private FullContext _db;

        public PassengerPathRefService(FullContext db)
        {
            _db = db;
        }

        public void Delete(int id)
        {
            PassengerPathRef reference = GetById(id);

            if (reference != null)
            {
                _db.PassengerPathRefs.Remove(reference);
            }

            _db.SaveChangesAsync();
        }

        public IEnumerable<PassengerPathRef> GetAll()
        {
            return _db.PassengerPathRefs;
        }

        public PassengerPathRef GetById(int id)
        {
            PassengerPathRef reference = null;
            foreach (var item in _db.PassengerPathRefs)
            {
                if (item.Id == id)
                {
                    reference = item;
                    break;
                }
            }

            return reference;
        }

        public void Post(PassengerPathRef item)
        {
            _db.PassengerPathRefs.Add(item);

            _db.SaveChangesAsync();
        }

        public void Put(PassengerPathRef item)
        {
            PassengerPathRef reference = GetById(item.Id);
            if (reference != null)
            {
                reference.PathId = item.PathId;
                reference.PathId = item.UserId;

                _db.SaveChangesAsync();
            }
        }

        public List<PassengerPathRef> GetPassengersList(int pathId)
        {
            List<PassengerPathRef> result = new List<PassengerPathRef>();
            foreach (var item in _db.PassengerPathRefs)
            {
                if (item.Id == pathId)
                {
                    result.Add(item);
                    break;
                }
            }

            return result;
        }
    }
}
