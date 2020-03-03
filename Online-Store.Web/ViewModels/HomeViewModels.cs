﻿using Online_Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Store.Web.ViewModels
{
    public class HomeViewModel
    {
        public List<Category> FeaturedCategories { get; set; }
        public List<Product> FeaturedProducts { get; set; }

    }
}