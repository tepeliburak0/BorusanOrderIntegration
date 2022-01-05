using BorusanOrderIntegration.Business.Abstract;
using BorusanOrderIntegration.Core.Results;
using BorusanOrderIntegration.DataAccess.Abstract;
using BorusanOrderIntegration.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorusanOrderIntegration.Business.Concrete
{
    public class StockDetailManager : IStockDetailService
    {
        private IStockDetailDal _stockDetailDal;
        public StockDetailManager(IStockDetailDal stockDetailDal)
        {
            _stockDetailDal = stockDetailDal;
        }
        public IResult Add(StockDetail stockDetail)
        {
            _stockDetailDal.Add(stockDetail);

            return new SuccessResult();
        }

        public IDataResult<StockDetail> GetById(string stockId)
        {
            return new SuccessDataResult<StockDetail>(_stockDetailDal.Get(c => c.StockId == stockId));
        }
    }
}
