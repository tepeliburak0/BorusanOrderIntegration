using BorusanOrderIntegration.Core.Results;
using BorusanOrderIntegration.Entities.DTOs;
using BorusanOrderIntegration.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorusanOrderIntegration.Business.Abstract
{
   public interface IOrderStatusService
    {
        IDataResult<List<OrderStatus>> GetAll();

        IDataResult<OrderStatusDto> PostOrderStatus(OrderStatusDto OrderStatusDto);
    }
}
