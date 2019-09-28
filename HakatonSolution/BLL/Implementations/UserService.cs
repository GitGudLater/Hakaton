using System.Collections.Generic;
using BLL.Implementations.DataAccess;
using BLL.Interfaces;
using Common.JsonModels;
using Common.Model;

namespace BLL.Implementations
{
    public class UserService : IUserService
    {
        private FullContext _db;

        public UserService(FullContext db)
        {
            _db = db;
        }

        public void Delete(int id)
        {
            User user = GetById(id);

            if (user != null)
            {
                _db.Users.Remove(user);
            }

            _db.SaveChangesAsync();
        }

        public IEnumerable<User> GetAll()
        {
            return _db.Users;
        }

        public User GetById(int id)
        {
            User user = null;
            foreach (var item in _db.Users)
            {
                if (item.Id == id)
                {
                    user = item;
                    break;
                }
            }

            return user;
        }

        public void Post(User item)
        {
            _db.Users.Add(item);

            _db.SaveChangesAsync();
        }

        public void Put(User item)
        {
            User user = GetById(item.Id);
            if (user != null)
            {
                user.Car = item.Car;
                user.Description = item.Description;
                user.Email = item.Email;
                user.Password = item.Password;

                _db.SaveChangesAsync();
            }
        }

        public JsonUser GetJsonUser(int userId)
        {
            JsonUser result = new JsonUser();

            User user = GetById(userId);

            result.Car = user.Car;
            result.Description = user.Description;
            result.Email = user.Email;
            result.Id = user.Id;
            result.Password = user.Password;

            return result;
        }
    }
}
