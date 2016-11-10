using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WeatherService;
using WeatherService.Models;

namespace Weather.Controllers
{
    public class MapController : Controller
    {
        // GET: Map
        public ActionResult Index(string cityname="Kathmandu")
        {
            IRequestModel tmp = new CityNameModel() { CityName = cityname } ;
            GenerateURL urlobj = new GenerateURL(Endpoints.ByCityName, tmp.Get());

            //Content = new StringContent(Test.CreateObject(urlobj.GeneratedURL));
            string str = Test.CreateObject(urlobj.GeneratedURL);

            var yourObject = JsonConvert.DeserializeObject<Weather.Models.Weathers>(str);
            return View(yourObject);
        }
    }
}