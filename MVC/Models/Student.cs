using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVC.Models;

[Table("Student")]
public class Student
{
    [Key]
    public int MaSinhVien {get; set; }
    public string? HoTen {get; set; }
    public string? DiaChi {get; set; }
}