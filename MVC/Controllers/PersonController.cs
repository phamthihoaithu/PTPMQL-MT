using Microsoft.AspNetCore.Mvc;
using MVC.Models;
namespace MVC.Controllers;
public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string strResult = "Xin chào " + ps.FullName + " - " + ps.DiaChi;
        ViewBag.Person = strResult;
        return View();
    }
}