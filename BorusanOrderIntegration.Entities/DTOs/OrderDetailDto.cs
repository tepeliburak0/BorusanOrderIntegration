using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorusanOrderIntegration.Entities.DTOs
{
   public class OrderDetailDto
    {
        public string CustomerOrderId { get; set; }
        public int SystemOrderId { get; set; }
        public bool Status { get; set; }
        public string Error { get; set; }

    }
}
