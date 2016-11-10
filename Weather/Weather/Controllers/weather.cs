using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeatherService.Models;
using WeatherService;
using System.Threading.Tasks;
using Weather.Models;
using Newtonsoft.Json;

namespace Weather.Controllers
{
    [RoutePrefix("api/weather")]
    public class weatherController : ApiController
    {
        // POST api/<controller>
        [HttpPost]
        public HttpResponseMessage DataByName(CityNameModel cityName)
        {
            
            IRequestModel tmp = cityName;
            GenerateURL urlobj = new GenerateURL(Endpoints.ByCityName, tmp.Get());
            
            var response =  new HttpResponseMessage() { Content = new StringContent(Test.CreateObject(urlobj.GeneratedURL)) };
            //string str = response.ToString();
          
            //var yourObject = JsonConvert.DeserializeObject<Weather.Models.Weathers>(str);

            return response;

        }

        [HttpPost]
        public HttpResponseMessage DataById(CityIdModel cityId)
        {
            IRequestModel tmp = cityId;
            GenerateURL urlobj = new GenerateURL(Endpoints.ByCityId, tmp.Get());
            
            return new HttpResponseMessage() { Content = new StringContent(Test.CreateObject(urlobj.GeneratedURL)) };
        }

        [HttpPost]
        public HttpResponseMessage DataByCoordinates(CoordinatesModel coOrdinates)
        {
            IRequestModel tmp = coOrdinates;
            GenerateURL urlobj = new GenerateURL(Endpoints.ByCoordinates, tmp.Get());
            
            return new HttpResponseMessage() { Content = new StringContent(Test.CreateObject(urlobj.GeneratedURL)) };
        }

        [HttpPost]
        public HttpResponseMessage DataByZipCode(ZipCodeModel zipCode)
        {
            IRequestModel tmp = zipCode;
            GenerateURL urlobj = new GenerateURL(Endpoints.ByZipCode, tmp.Get());

            return new HttpResponseMessage() { Content = new StringContent(Test.CreateObject(urlobj.GeneratedURL)) };
        }

        [HttpPost]
        public HttpResponseMessage DataByRectangleZone(RectangelZoneModel rectangleZone)
        {
            IRequestModel tmp = rectangleZone;
            GenerateURL urlobj = new GenerateURL(Endpoints.ByRectangleZone, tmp.Get());

            return new HttpResponseMessage() { Content = new StringContent(Test.CreateObject(urlobj.GeneratedURL)) };
        }

        [HttpPost]
        public HttpResponseMessage DataByCitiesCycle(CitiesCycleModel citiesCycle)
        {
            IRequestModel tmp = citiesCycle;
            GenerateURL urlobj = new GenerateURL(Endpoints.ByCitiesCycle, tmp.Get());

            return new HttpResponseMessage() { Content = new StringContent(Test.CreateObject(urlobj.GeneratedURL)) };
        }

        [HttpPost]
        public HttpResponseMessage DataByCitiesId(MultipleCitiesModel multipleCitiesId)
        {
            IRequestModel tmp = multipleCitiesId;
            GenerateURL urlobj = new GenerateURL(Endpoints.ByCitiesId, tmp.Get());

            return new HttpResponseMessage() { Content = new StringContent(Test.CreateObject(urlobj.GeneratedURL)) };
        }
    }
    
}
