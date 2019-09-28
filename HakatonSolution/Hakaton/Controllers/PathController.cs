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
    public class PathController : ControllerBase
    {
        IPathService pathService;

        // GET api/values/5
        [HttpGet]
        public ActionResult<IEnumerable<JsonPath>> GetAll()
        {
            Path[] pathes = pathService.GetAll().ToArray();

            int len = pathes.Count();

            JsonPath[] jsonPathes = new JsonPath[len];

            for(int i = 0; i < len; i++)
            {
                jsonPathes[i] = ConvertToJsonPath(pathes[i]);
            }
            return jsonPathes;
        }

        [HttpGet("{id}")]
        public ActionResult<JsonPath> Get(int id)
        {
            return ConvertToJsonPath(pathService.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public void post([FromBody] JsonPath path)
        {
            pathService.Post(ConvertToPath(path));
        }
        
        
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] JsonPath path)
        {
            pathService.Put(ConvertToPath(path));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            pathService.Delete(id);
        }

        Path ConvertToPath(JsonPath path)
        {
            return new Path();
        }

        JsonPath ConvertToJsonPath(Path path)
        {
            return new JsonPath();
        }
    }
}
