﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StocktrackService.models
{
    [DataContract]
    public class Transaction
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Qty { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember] 
        DateTime added { get; set; }
        [DataMember]
        public Store Store { get; set; }
        [DataMember]
        public Product Product { get; set; }
    }
}