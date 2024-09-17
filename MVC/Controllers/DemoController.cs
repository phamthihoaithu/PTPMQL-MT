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
    //trả dữ liệu về View để hiển thị
    public IActionResult Index(string FullName)
    {
        string strResult = "Xin chào " + FullName;
        ViewBag.Demo = strResult;
        return View();
    }

    //Trong Model string? cho phép null, string k cho phép null
}