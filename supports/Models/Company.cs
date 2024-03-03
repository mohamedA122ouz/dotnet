using System.ComponentModel.DataAnnotations;

namespace supports.Models;
public class Company{
    public string Name { get; set; }
    [Key]
    public int Id { get; set; }
}