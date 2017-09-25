using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;

namespace MVC.Controllers
{
  public class ProductsController : Controller
  {

    ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {


      return View();
    }

    public IActionResult ViewProducts(){
      Products _data = new Products();
      _data.Name = "Book";
      _data.Detail = "ASP.NET Core MVC";
      _data.Price = 150.25M;
      return View(_data);
    }
  }
}