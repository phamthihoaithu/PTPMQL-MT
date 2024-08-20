using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVC.Models;

[Table("Student")]
public class Student
{
    [Key]
    public int StudentID {get; set; }
    public string? FullName {get; set; }
    public string? Address {get; set; }
}