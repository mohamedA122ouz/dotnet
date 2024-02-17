using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using supports.Models;

namespace supports.Controllers;
class Temp {
    static public Product P = null;
    static public bool Editable = false;
}
public class DashboardController : Controller
{
    public static List<Product>  _p = new();
    private Product temp = null;
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
        if (!Temp.Editable) {

            if (_p.Count == 0) {
                p.ID = 1;
            }
            else if (_p.Count >= 1) {
                p.ID = _p.Max((el) => el.ID) + 1;
            }
            DashboardController._p.Add(p);
            return RedirectToAction("index");
        }
        Temp.P.Price = p.Price;
        Temp.P.Description = p.Description;
        Temp.P.Name = p.Name;
        Temp.P.Description = p.Description;
        Temp.Editable = false;
        Temp.P = null;
        return RedirectToAction("GetAllData");
    }
    public IActionResult GetAllData() {
        return View(DashboardController._p);
    }
    public IActionResult Remove(int id) {
        var Prod = _p.FirstOrDefault(el => el.ID == id);
        _p.Remove(Prod);
        return RedirectToAction("GetAllData");
    }
    public IActionResult Edit(int id) {
        var temp = _p.FirstOrDefault(el => el.ID == id);
        Temp.P = temp;
        Temp.Editable = true;
        return RedirectToAction("AddProduct");
    }

}
