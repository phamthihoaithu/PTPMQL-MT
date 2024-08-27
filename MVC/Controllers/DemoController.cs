using Microsoft.AspNetCore.Mvc;
namespace MVC.Controllers;
public class DemoController : Controller
{
    //hiển thị trên View
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost] //nhận dl từ View
    //trả dl về View
    public IActionResult Index(string FullName)
    {
        string strResult = "Xin chào " + FullName;
        ViewBag.Demo = strResult;
        return View();
    }
}