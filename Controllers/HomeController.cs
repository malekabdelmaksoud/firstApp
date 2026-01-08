using firstApp.Models;
using firstApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace firstApp.Controllers
{
    public class HomeController :Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductService _service;
        public HomeController(ILogger<HomeController> logger, ProductService service)
        {
            _logger = logger;
            _service = service;
        }

        


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        


        public IActionResult Index()
        {
            var products = _service.GetAll();
            return View(products);
        }


     

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _service.Add(product);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {
            var product = _service.GetById(id);
            if (product == null) return NotFound();
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _service.Update(product);
            return RedirectToAction("Index");
        }


       
        [HttpPost]
        public IActionResult Delete()
        {
          
            _service.Delete();

            return RedirectToAction("Index"); 
        }
       





}
    
}
