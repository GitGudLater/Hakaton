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
    public class PassangerController : ControllerBase
    {
        IPassengerPathRefService passangerService;
        IUserService userService;

        // GET api/values/5
        

        // POST api/values
        [HttpPost]
        public void Post([FromBody] JsonPassager passager)
        {
            try
            {
                userService.GetById(Int32.Parse(Request.Cookies.FirstOrDefault(n => n.Key == "id").Value));
            }
            catch(Exception ex)
            {
            }
            passangerService.Post(ConvertToPassager(passager));
        }

        
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            passangerService.Delete(id);
        }

        PassengerPathRef ConvertToPassager(JsonPassager path)
        {
            return new PassengerPathRef();
        }

        JsonPassager ConvertToJsonPassager(PassengerPathRef path)
        {
            return new JsonPassager();
        }
    }
}
