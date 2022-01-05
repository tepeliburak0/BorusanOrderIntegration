using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorusanOrderIntegration.Entities.DTOs
{
   public class OrderStatusDto
    {
        public string CustomerOrderId { get; set; }
        public string Status { get; set; }
        public DateTime DateTime { get; set; }
    }
}
