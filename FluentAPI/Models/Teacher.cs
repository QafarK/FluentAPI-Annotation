using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace FluentAPI.Models;

internal class Teacher
{
    [Key]
    [Required]
    [Column("Id")]
    public int TeacherId { get; set; }

    [Required]
    [Column("Name")]
    [MaxLength(int.MaxValue)]
    public string FirstName { get; set; }

    [Required]
    [Column("Surname")]
    [MaxLength(int.MaxValue)]
    public string LastName { get; set; }

    [BirthdateAfter1990]
    public DateTime EmploymentDate { get; set; }

    [Required]
    [Range(0, double.MaxValue)]
    public decimal Premium { get; set; } = 0;

    [Required]
    [Range(0, double.MaxValue)]
    public decimal Salary { get; set; } = 0;



}
