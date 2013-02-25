﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace SignalRMarketEx.Models
{
    public class ItemEntity
    {
        [JsonProperty(PropertyName = "itemId")]
        public int Id { get; private set; }
        [JsonProperty(PropertyName="product")]
        public string Product { get; set; }
        [JsonProperty(PropertyName="description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName="bid")]
        public decimal? Bid { get; set; }
        [JsonProperty(PropertyName="ask")]
        public decimal? Ask { get; set; }
        [JsonProperty(PropertyName="lastPrice")]
        public decimal? LastPrice { get; set; }
        public ItemEntity()
        {
            //Will be generated by the db identity
            Id = new Random().Next();
        }
    }
}