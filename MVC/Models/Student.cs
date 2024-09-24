using System.ComponentModel.DataAnnotations;
namespace MVC.Models;

public class Student
{
    [Key]
    public string MaSinhVien {get; set; }
    public string HoTen {get; set; }
    public string? DiaChi {get; set; }
}