using AIRMDataManager.Library.Internal.DataAccess;
using AIRMDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRMDataManager.Library.DataAccess
{
  public class ProductData
  {
    public List<ProductModel> GetProducts()
    {
      SqlDataAccess sql = new SqlDataAccess();

      var output = sql.LoadData<ProductModel, dynamic>("dbo.spProduct_GetAll", new { }, "AIRMData");

      return output;
    }
  }
}
