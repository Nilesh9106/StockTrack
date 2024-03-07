using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime added { get; set; }
        [DataMember]
        public Store Store { get; set; }
        [DataMember]
        public Product Product { get; set; }
    }
}
