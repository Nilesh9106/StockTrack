﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StocktrackService.models
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public int Qty { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public Store Store { get; set; }

    }
}
