﻿using countrycity.model;

namespace countrycity.data
{
    public class Country
    {

        public int id { get; set; }
        public string name { get; set; }

        public string code { get; set; }
        List<CityDTO> ciy { get; set; }


    }
}
