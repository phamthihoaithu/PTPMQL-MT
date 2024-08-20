using System.ComponentModel.DataAnnotations;
namespace MVC.Models;

public class Student
{
    [Key]
    public int StudentID {get; set; }
    public string? FullName {get; set; }
}