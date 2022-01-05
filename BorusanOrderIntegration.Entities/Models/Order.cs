
using BorusanOrderIntegration.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BorusanOrderIntegration.Entities.Models
{
    public class Order:IEntity
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string CustomerOrderId { get; set; }
        public string OutputAdress { get; set; }
        public string InputAdress { get; set; }
        public int Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public int Weight { get; set; }
        public string WeightUnit { get; set; }
        public string StockId { get; set; }
        public string StockName { get; set; }
        public string Note { get; set; }

        
        public string Status { get; set; }

       
    }
}
