using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Common.JsonModels;
using Common.Model;
using BLL.Interfaces;

namespace Hakaton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IUserService userService; 

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<JsonUser> Get(int id)
        {
            return userService.GetJsonUser(id);
        }

        // POST api/values
        [HttpPost("/register")]
        public void Register([FromBody] JsonUser user)
        {
            userService.Post(ConvertToUser(user));
        }

        [HttpPost("/login")]
        public ActionResult<bool> LogIn([FromBody] JsonUser user)
        {
            return Authorizer(user);
        }

        private bool Authorizer(JsonUser user)
        {
            Common.Model.User user1 = userService.GetAll().FirstOrDefault(userr => userr.Email == user.Email);
            if(user1 != null && user.Password == user1.Password)
            {
                Response.Cookies.Append("loginCookie", user.Id.ToString());
                return true;
            }
            return false;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] JsonUser user)
        {
            userService.Put(ConvertToUser(user));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            userService.Delete(id);
        }

        User ConvertToUser(JsonUser user)
        {
            return new User() { Id = user.Id, Car = user.Car, Description = user.Description, Email = user.Email, Password = user.Password };
        }

        JsonUser ConvertToJsonUser(User user)
        {
            return new JsonUser() { Id = user.Id, Car = user.Car, Description = user.Description, Email = user.Email, Password = user.Password };
        }
    }
}
