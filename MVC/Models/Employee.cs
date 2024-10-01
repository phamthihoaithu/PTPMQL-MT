using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVC.Models;
public class Employee : Person
{
    public string EmployeeID { get; set; }
    public string SDT { get; set;}
}