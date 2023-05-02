﻿using AIRMDataManager.Library.DataAccess;
using AIRMDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AIRMDataManager.Controllers
{
  //[Authorize]
  [Authorize(Roles = "Cashier")]
  public class ProductController : ApiController
  {
    public List<ProductModel> Get()
    {

      ProductData data = new ProductData();

      return data.GetProducts();
    }

  }
}
