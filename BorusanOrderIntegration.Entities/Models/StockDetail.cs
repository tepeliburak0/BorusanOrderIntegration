
using BorusanOrderIntegration.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorusanOrderIntegration.Entities.Models
{
   public class StockDetail : IEntity
    {
        public int Id { get; set; }
        public string StockId { get; set; }
        public string StockName { get; set; }

    }
}
