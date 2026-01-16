using firstApp.data;
using firstApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace firstApp.Services
{
    public class ProductService
    {
        private readonly Mvcdbcontext _context;

        public ProductService(Mvcdbcontext context)
        {
            _context = context;
        }

        // READ
        public List<Product> GetAll()
        {
           
            return _context.Products .ToList();
        }


        public Product? GetById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id );
        }

        // CREATE
        public void Add(Product product)
        {
         
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        // UPDATE
        public void Update(Product product)
        {
            var e = GetById(product.Id);
            if (e != null)
            {
                e.Name = product.Name;
                e.Price = product.Price;
                e.CategoryId = product.CategoryId;
                _context.Products.Update(e);
                _context.SaveChanges();
            }
        }

        // DELETE
        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
 }
