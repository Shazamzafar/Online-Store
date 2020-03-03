using Online_Store.Database;
using Online_Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Online_Store.Services
{
   public class ProductService
    {

        public Product GetProduct(int ID)
        {
            using (var context = new OSContext())
            {
                return context.Products.Find(ID);
            }
        }

        public  List<Product> GetProducts()
        {
            //var context = new OSContext();
            //return context.Products.ToList();

            using (var context = new OSContext())
            {
                return context.Products.Include(x => x.Category).ToList();
            }
        }

        public void SaveProduct(Product product)
        {
            using (var context = new OSContext())
            {
                context.Entry(product. Category).State = System.Data.Entity.EntityState.Unchanged;


                context.Products.Add(product);

                context.SaveChanges();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var context = new OSContext())
            {

                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }


        public void DeleteProduct(int ID)
        {
            using (var context = new OSContext())
            {


                var product = context.Products.Find(ID);

                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        public void UpdateProduct(int iD)
        {
            throw new NotImplementedException();
        }
    }
}
