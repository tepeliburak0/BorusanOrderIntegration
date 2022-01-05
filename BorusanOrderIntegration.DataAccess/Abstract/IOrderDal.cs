using BorusanOrderIntegration.Core.DataAccess;
using BorusanOrderIntegration.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorusanOrderIntegration.DataAccess.Abstract
{
   public interface IOrderDal : IEntityRepository<Order>
    {
    }
}
