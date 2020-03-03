﻿using Online_Store.Entities;
using Online_Store.Services;
using Online_Store.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Store.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductService productsService = new ProductService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ProductTable(string search)
        {
            var products = productsService.GetProducts();

            if (string.IsNullOrEmpty(search) ==false)
            {
                products = products.Where(p => p.Name != null && p.Name.ToLower() .Contains(search.ToLower())).ToList();
            }

            return PartialView(products);
        }

        [HttpGet]
        public ActionResult Create()
        {

            CategoriesServices categoryService = new CategoriesServices();

            var categories = categoryService.GetCategories();

            return PartialView(categories);
        }

        [HttpPost]
        public ActionResult Create(NewCategoryViewModel model)
        {

           CategoriesServices categoryService = new CategoriesServices();

            var newProduct = new Product();
            newProduct.Name = model.Name;
            newProduct.Description = model.Description;
            newProduct.Price = model.Price;
            //newProduct.CategoryID = model.CategoryID;
            newProduct.Category = categoryService.GetCategory(model.CategoryID);


            productsService.SaveProduct(newProduct);

            return RedirectToAction("ProductTable");
        }


        [HttpGet]
        public ActionResult Edit( int ID)
        {
            var product = productsService.GetProduct(ID);

            return PartialView(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productsService.UpdateProduct(product);

            return RedirectToAction("ProductTable");
        }


        [HttpPost]
        public ActionResult Delete(int ID)
        {
            productsService.DeleteProduct(ID);

            return RedirectToAction("ProductTable");
        }
    }


}