using Online_Store.Services;
using Online_Store.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Store.Web.Controllers
{
    public class WidgetssController : Controller
    {
        // GET: Widgetss
        public ActionResult Products(bool isLatestProducts)
        {
            ProductsWidgetViewModel model = new ProductsWidgetViewModel();
            model.isLatestProducts = isLatestProducts;

            if (isLatestProducts)
            {
                model.Products = ProductsService.Instance.GetLatestProducts(4);
            }
            else
            {
                model.Products = ProductsService.Instance.GetProducts(1, 8);
            }

            return PartialView(model);
        }
    }
}