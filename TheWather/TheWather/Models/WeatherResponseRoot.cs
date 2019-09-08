﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheWather.Models
{
    public class WeatherResponseRoot : BaseModel
    {
        public Coord Coord { get; set; }
        public Weather[] Weather { get; set; }
        public string Base { get; set; }
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public int Dt { get; set; }
        public Sys Sys { get; set; }
        public int TimeZone { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
    }
}
