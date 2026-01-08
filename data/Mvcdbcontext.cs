using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace firstApp.data
{
    
    public class Mvcdbcontext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=mvcdbcontext;user=root;password=", ServerVersion.AutoDetect("server=localhost;database=mvcdbcontext;user=root;password="));
        }
        

        
    } 
}
