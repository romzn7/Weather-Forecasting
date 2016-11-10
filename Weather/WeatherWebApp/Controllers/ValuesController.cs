using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeatherService;
using WeatherService.Models;

namespace WeatherWebApp.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }



        [HttpPost]
        [Route("api/Values/GetByName")]
        public string GetByName(string cityName)
        {
            IRequestModel tmp = new CityNameModel() { CityName = cityName };
            GenerateURL urlobj = new GenerateURL(Endpoints.ByCityName, tmp.Get());
            string genurl = urlobj.GeneratedURL;
            return Test.CreateObject(urlobj.GeneratedURL);
        }
    }
}
