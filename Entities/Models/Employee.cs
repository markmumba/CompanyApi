using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

public class Employee
{
    [Column("EmployeeId")]
    public Guid Id {get; set;}
    [Required(ErrorMessage = "Name of employee must be provided")]
    [MaxLength(30,ErrorMessage ="Name characters should not exceed 30")]
    public string? Name {get; set;}

    [Required(ErrorMessage = "Age is a required field ")]
    public int Age {get; set;}
    [Required(ErrorMessage ="positon should be provided")]
    [MaxLength(60,ErrorMessage ="maximum length position is 60")]
    public string? Position {get; set;}


    [ForeignKey(nameof(Company))]
    public Guid CompanyId {get; set;}
    public Company? Company {get; set;}

}
