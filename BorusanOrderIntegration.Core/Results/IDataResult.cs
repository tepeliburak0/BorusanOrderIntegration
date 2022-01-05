using System;
using System.Collections.Generic;
using System.Text;

namespace BorusanOrderIntegration.Core.Results
{
  public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
