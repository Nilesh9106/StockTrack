using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StocktrackService.models
{
    [DataContract]
    public class Response
    {
        [DataMember]
        public int Code {  get; set; }
        [DataMember] 
        public string Message { get; set; }
    }
}
