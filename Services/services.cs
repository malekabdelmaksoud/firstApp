using firstApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace firstApp.Services
{
    public class ProductService
    {
        private static List<Product> Products = new();

        // READ
        public List<Product> GetAll()
        {
            return Products;
        }

        public Product? GetById(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }

        // CREATE
        public void Add(Product product)
        {
            product.Id = Products.Count + 1;
            Products.Add(product);
        }

        // UPDATE
        public void Update(Product product)
        {
            var p = GetById(product.Id);
            if (p != null)
            {
                p.Name = product.Name;
                p.Price = product.Price;
                p.CategoryId = product.CategoryId;
            }
        }

        // DELETE
        public void Delete()
        {
            int id = 1; // Placeholder for the actual id to delete
            var p = GetById(id);
            if (p != null)
                Products.Remove(p);
        }
    }
}
