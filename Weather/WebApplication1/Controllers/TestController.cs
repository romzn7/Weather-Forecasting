using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeatherService;
using WeatherService.Models;

namespace WebApplication1.Controllers
{
    public class TestController : ApiController
    {

        [HttpPost]
        //[Route("api/Values/GetByName")]
        public string GetByName(string cityName)
        {
            IRequestModel tmp = new CityNameModel() { CityName = cityName };
            GenerateURL urlobj = new GenerateURL(Endpoints.ByCityName, tmp.Get());
            string genurl = urlobj.GeneratedURL;
            return Test.CreateObject(urlobj.GeneratedURL);
        }
    }
}
