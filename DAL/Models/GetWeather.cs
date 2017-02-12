using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using WeatherApp.DAL.Interfaces;

namespace WeatherApp.DAL.Models
{
    class GetWeather : IApiRequest
    {
        private double lat;
        private double lon;

        public GetWeather(double lat, double lon)
        {
            this.lat = lat;
            this.lon = lon;
        }
        public void GetCurrentWeather()
        {
            throw new NotImplementedException();
        }

        public void GetFiveDayThreeHourWeather()
        {
            throw new NotImplementedException();
        }

        public void GetSixteenDaysDailyWeather()
        {
            throw new NotImplementedException();
        }

        private void WeatherAPIRequestCurrect()
        {
            string appId = "";
            string result = "";

            string url = String.Format(@"api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&APPID={2}", lat, lon, appId);
            var wrUrl = (HttpWebRequest)WebRequest.CreateHttp(url);
            wrUrl.Accept = "application/json";
            wrUrl.Method = "GET";

            var httpResponse = (HttpWebResponse)wrUrl.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
        }
        private void WeatherAPIRequestForecast()
        {
            string appId = "";
            string result = "";

            string url = String.Format(@"api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&APPID={2}", lat, lon, appId);
            var wrUrl = (HttpWebRequest)WebRequest.CreateHttp(url);
            wrUrl.Accept = "application/json";
            wrUrl.Method = "GET";

            var httpResponse = (HttpWebResponse)wrUrl.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
        }
        private void JSONWeatherParserCurrent(string responce)
        {

        }
        private void JSONWeatherParserForecast(string responce)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
        }
    }
}
