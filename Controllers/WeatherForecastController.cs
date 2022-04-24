using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudOperationWithStaticData.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        static List<string> strings = new List<string>()
    {
        "value0", "value1", "value2"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet] //Get All
        public IEnumerable<string> Get()
        {
            return strings;
        }

        [HttpPatch] //Get By
        public string Get(int id)
        {
            return strings[id];
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
            strings.Add(value);
        }
        [HttpPut]
        public void Put(int id,[FromBody]string value)
        {
            strings[id]= value;
        }
        [HttpDelete]
        public void Delete (int id)
        {
            strings.RemoveAt(id);
        }
    }
}
