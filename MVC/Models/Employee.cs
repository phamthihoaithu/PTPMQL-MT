using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVC.Models;
public class Employee
{
    [Key]
    public string EmployeeID {get; set; }
    public string FullName {get; set; }
    public string Address {get; set; }
}
