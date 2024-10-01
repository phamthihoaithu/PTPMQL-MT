using System.ComponentModel.DataAnnotations;
namespace MVC.Models;
public class Person
{
    [Key]
    public string CCCD { get; set; }
    public string HoTen { get; set; }
    public string QueQuan { get; set; }
}  