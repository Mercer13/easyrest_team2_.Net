﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Team2.Net.DataEntities
{
    public class RestaurantInfo
    {
        [JsonProperty("data")]
        public List<Data> Data { get; set; }
    }
    public class ClientInfo
    {
        [JsonProperty("data")]
        public List<Data> Data { get; set; }
        
    }

    public class LoginInfo
    {
        [JsonProperty("data")]
        public List<Data> Data { get; set; }

    }
    
}
