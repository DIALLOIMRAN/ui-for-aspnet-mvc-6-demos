﻿using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNet.Mvc;

namespace Kendo.Mvc.Examples.Controllers
{
    public partial class GridController : Controller
    {
        public ActionResult Aggregates()
        {
            return View();
        }
        
        public ActionResult Aggregates_Read([DataSourceRequest] DataSourceRequest request)
        {
            var products = productService.Read();

            return Json(products.ToDataSourceResult(request));
        }
    }
}