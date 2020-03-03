﻿using Online_Store.Database;
using Online_Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Store.Services
{
   public class CategoriesServices
    {

        public Category GetCategory(int ID)
        {
            using (var context = new OSContext())
            {
                return context.Categories.Find(ID);
            }
        }

        public  List<Category> GetCategories()
        {
            using (var context = new OSContext())
            {
                return context.Categories.ToList();
            }
        }

        public List<Category> GetFeaturedCategories()
        {
            using (var context = new OSContext())
            {
                return context.Categories.Where(x=>x.isFeatured && x.ImageURL != null).ToList();
            }
        }

        public void SaveCategory(Category category)
        {
            using (var context = new OSContext())
            {
                context.Categories.Add(category);

                context.SaveChanges();
            }
        }

        public void UpdateCategory(Category category)
        {
            using (var context = new OSContext())
            {

                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }


        public void DeleteCategory(int ID)
        {
            using (var context = new OSContext())
            {


                var category = context.Categories.Find(ID);

                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}