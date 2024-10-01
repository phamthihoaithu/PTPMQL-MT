using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
namespace MVC.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    //hiển thị trên View
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Demo()
    {
        return View();
    }
    [HttpPost] //nhận dl từ View
    //trả dữ liệu về View để hiển thị
    public IActionResult Demo(string FullName)
    {
        string strResult = "Xin chào " + FullName;
        ViewBag.Demo = strResult;
        return View();
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

    //Trong Model string? cho phép null, string k cho phép null
}
