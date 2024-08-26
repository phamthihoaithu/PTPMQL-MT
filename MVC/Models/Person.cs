using System.ComponentModel.DataAnnotations;
namespace MVC.Models;
public class Person
{
    [Key]
    public string? PersonID { get; set; }
    public string? FullName { get; set; }
    public string? DiaChi { get; set; }
}