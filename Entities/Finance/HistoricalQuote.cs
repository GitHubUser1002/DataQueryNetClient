﻿using System;
using Newtonsoft.Json;

namespace Entities.Finance
{
    public class HistoricalQuote
    {
        public string Symbol { get; set; }
        
        public DateTime Date { get; set; }
        
        public double Open { get; set; }

        public double High { get; set; }

        public double Low { get; set; }

        public double Close { get; set; }

        public int Volume { get; set; }
        
        [JsonProperty("Adj_Close")]
        public double AdjustedClose { get; set; }
    }
}
