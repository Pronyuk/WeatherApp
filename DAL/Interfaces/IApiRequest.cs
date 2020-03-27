using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.DAL.Interfaces
{
    interface IApiRequest
    {
        void GetCurrentWeather();
        void GetFiveDayThreeHourWeather();
        void GetSixteenDaysDailyWeather();
    }
}
