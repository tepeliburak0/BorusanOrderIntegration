using BorusanOrderIntegration.Business.Abstract;
using BorusanOrderIntegration.Core.Results;
using BorusanOrderIntegration.Core.Utilities.Business;
using BorusanOrderIntegration.DataAccess.Abstract;
using BorusanOrderIntegration.Entities.DTOs;
using BorusanOrderIntegration.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorusanOrderIntegration.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;
        private IStockDetailService _stockDetailService;
        private IOrderStatusService _orderStatusService;
        public OrderManager(IOrderDal orderDal, IStockDetailService stockDetailService, IOrderStatusService orderStatusService)
        {
            _orderStatusService = orderStatusService;
            _stockDetailService = stockDetailService;
            _orderDal = orderDal;
        }

        public IDataResult<OrderDetailDto> AddOrder(Order order)
        {
            IResult result = BusinessRules.Run(CheckIfProductNameExists(order.CustomerOrderId), CheckIfProductNameExists2(order.StockId,order.StockName));
            

            if (result!=null)
            {
                var errorData = new OrderDetailDto { CustomerOrderId = order.CustomerOrderId, Error = "", Status = false, SystemOrderId = 1 };
                return new ErrorDataResult<OrderDetailDto>(errorData);
            }

            order.Status = "Sipariş Alındı.";
            _orderDal.Add(order);
            var successData = new OrderDetailDto { CustomerOrderId = order.CustomerOrderId, Error = "", Status =true , SystemOrderId = 1 };
            return new SuccessDataResult<OrderDetailDto>(successData);

        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll());
        }

        public IDataResult<OrderStatusDto> PostOrderStatus(OrderStatusDto OrderStatusDto)
        {
            var result = _orderStatusService.PostOrderStatus(OrderStatusDto);

            return new SuccessDataResult<OrderStatusDto>();
        }

        private IResult CheckIfProductNameExists(string CustomerOrderId)
        {
            var result = _orderDal.GetAll(p => p.CustomerOrderId == CustomerOrderId).Any();
            if (result)
            {
                return new ErrorResult();
            }

            return new SuccessResult();
        }

        private IResult CheckIfProductNameExists2(string StockId, string StockName)
        {
            var result = _stockDetailService.GetById(StockId);

            if (result==null)
            {
                _stockDetailService.Add(new StockDetail { StockId = StockId, StockName = StockName });
                return new SuccessResult();
            }

            return new SuccessResult();
        }
    }
}
