﻿using Newtonsoft.Json;

namespace Team2.Net.DataEntities
{
    public class Data
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}