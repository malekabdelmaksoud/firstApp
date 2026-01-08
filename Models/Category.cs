using firstApp.Models;
using System;
using System.Collections.Generic;
namespace firstApp.Models
{
    public class Category
    {
        public int id { get; set; }
        public string? Name { get; set; } = null;
        
        public List<Category> Categories { get; set; } = new List<Category>();
        


        
    }
}
