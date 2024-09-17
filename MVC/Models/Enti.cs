using System.ComponentModel.DataAnnotations;
namespace MVC.Models;
public class Enti
{
    [Key]
    public string EntiID {get; set; }
    public string FullName {get; set; }
    public string? Address {get; set; }
}