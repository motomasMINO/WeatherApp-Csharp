using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class WeatherInfo
    {
        // 座標
        public class Coord
        {
            public double lon { get; set; } // 経度

            public double lat { get; set; } // 緯度
        }

        public class Weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class Main
        {
            public double temp { get; set; }

            public double pressure { get; set; }

            public double humidity { get; set; }
        }

        public class Wind
        {
            public double speed { get; set; }
        }

        public class Sys
        {
            public long sunrise { get; set; }

            public long sunset { get; set; }
        }

        public class Root
        {
            public Coord coord { get; set; }

            public List<Weather> weather { get; set; }

            public Main main { get; set; }

            public Wind wind { get; set; }

            public Sys sys { get; set; }
        }
    }
}
