using System.Collections.Generic;
using BLL.Implementations.DataAccess;
using BLL.Interfaces;
using Common.Model;

namespace BLL.Implementations
{
    public class PassengerRequestService : IPassengerRequestService
    {
        private FullContext _db;
        private UserService _userService;
        private PassengerPathRefService _passengerPathRefService;

        public PassengerRequestService(FullContext db, 
            UserService userService, 
            PassengerPathRefService passengerPathRefService)
        {
            _db = db;

            _userService = userService;
            _passengerPathRefService = passengerPathRefService;
        }

        public void Delete(int id)
        {
            PassengerRequest request = GetById(id);

            if (request != null)
            {
                _db.PassengerRequests.Remove(request);
            }

            _db.SaveChangesAsync();
        }

        public IEnumerable<PassengerRequest> GetAll()
        {
            return _db.PassengerRequests;
        }

        public PassengerRequest GetById(int id)
        {
            PassengerRequest request = null;
            foreach (var item in _db.PassengerRequests)
            {
                if (item.Id == id)
                {
                    request = item;
                    break;
                }
            }

            return request;
        }

        public void Post(PassengerRequest item)
        {
            _db.PassengerRequests.Add(item);

            _db.SaveChangesAsync();
        }

        public void Put(PassengerRequest item)
        {
            PassengerRequest request = GetById(item.Id);
            if (request != null)
            {
                request.PathId = item.PathId;
                request.UserId = item.UserId;

                _db.SaveChangesAsync();
            }
        }

        public IEnumerable<User> GetPathRequestUsers(int pathId)
        {
            List<User> result = new List<User>();
            foreach (var item in _db.PassengerRequests)
            {
                if (item.PathId == pathId)
                {
                    User user = _userService.GetById(item.UserId);
                    result.Add(user);
                    break;
                }
            }

            return result;
        }

        public void RequestApply(int passengerId, int pathId)
        {
            PassengerRequest request = null;

            foreach (var item in _db.PassengerRequests)
            {
                if (item.PathId == pathId && item.UserId == passengerId)
                {
                    request = item;
                    break;
                }
            }

            if (request != null)
            {
                _db.PassengerRequests.Remove(request);
                _passengerPathRefService.Post(
                    new PassengerPathRef()
                    { PathId = request.PathId, UserId = request.UserId}
                    );
            }
        }
    }
}
