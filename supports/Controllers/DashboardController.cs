using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using supports.Models;

namespace supports.Controllers;

public class DashboardController : Controller
{
    public static List<Product>  p = new();
    public IActionResult index(){

        return View();
    }
    public IActionResult Create(){
        return View();
    }
    public IActionResult AddProduct() {
        return View();
    }
    [HttpPost]
    public IActionResult AddProduct([FromForm]Product p) {
        DashboardController.p.Add(p);
        return RedirectToAction("index");
    }

}
