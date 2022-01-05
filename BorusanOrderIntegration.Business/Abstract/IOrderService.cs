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
   public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<OrderDetailDto> AddOrder(Order order);
        IDataResult<OrderStatusDto> PostOrderStatus(OrderStatusDto OrderStatusDto);

    }
}
