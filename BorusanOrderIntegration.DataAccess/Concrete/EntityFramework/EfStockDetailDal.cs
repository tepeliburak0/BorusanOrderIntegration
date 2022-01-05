using BorusanOrderIntegration.Core.DataAccess.EntityFramework;
using BorusanOrderIntegration.DataAccess.Abstract;
using BorusanOrderIntegration.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorusanOrderIntegration.DataAccess.Concrete.EntityFramework
{
    public class EfStockDetailDal : EfEntityRepositoryBase<StockDetail, OrderDbContext>, IStockDetailDal
    {
    }
}
