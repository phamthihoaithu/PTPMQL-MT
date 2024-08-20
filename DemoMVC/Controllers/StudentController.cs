using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controller;

public class StudentController
{
    public IActionResult Index()
    {
        return View();
    }

    private IActionResult View()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public IActionResult Index(string MaSinhVien, string HoTen)
    {
        string strResult = "Xin chao " + MaSinhVien + "-" + HoTen;
        ViewBag.Info = strResult;
        return View();
    }
}

internal class ViewBag
{
    public static string Info { get; internal set; }
}