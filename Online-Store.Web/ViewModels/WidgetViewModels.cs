using Online_Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Store.Web.ViewModels
{
    public class ProductsWidgetViewModel
    {
        public List<Product> Products { get; set; }

        public bool isLastestProducts { get; set; }
        public bool IsLatestProducts { get; internal set; }
    }
}