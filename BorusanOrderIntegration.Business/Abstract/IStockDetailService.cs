using BorusanOrderIntegration.Core.Results;
using BorusanOrderIntegration.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorusanOrderIntegration.Business.Abstract
{
   public interface IStockDetailService
    {
        IDataResult<StockDetail> GetById(string stockId);
        IResult Add(StockDetail stockDetail);
    }
}
