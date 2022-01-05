using BorusanOrderIntegration.Business.Abstract;
using BorusanOrderIntegration.Core.Results;
using BorusanOrderIntegration.DataAccess.Abstract;
using BorusanOrderIntegration.Entities.DTOs;
using BorusanOrderIntegration.Entities.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorusanOrderIntegration.Business.Concrete
{
    public class OrderStatusManager : IOrderStatusService
    {
        private IOrderStatusDal _orderStatusDal;
        public OrderStatusManager(IOrderStatusDal orderStatusDal)
        {
            _orderStatusDal = orderStatusDal;
        }
        public IDataResult<List<OrderStatus>> GetAll()
        {
            return new SuccessDataResult<List<OrderStatus>>(_orderStatusDal.GetAll());
        }

        public IDataResult<OrderStatusDto> PostOrderStatus(OrderStatusDto OrderStatusDto)
        {
            var json = JsonConvert.SerializeObject(OrderStatusDto);
            var client = new RestClient("http://api.xx.com/statu");
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("cache-control", "no-cache");
            request.AddJsonBody(json);
            var response = client.Execute(request);

            return new SuccessDataResult<OrderStatusDto>(response.Content);
        }
    }
}
