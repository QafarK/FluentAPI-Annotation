using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace FluentAPI.Models;

internal class Department
{
    [Key]
    [Required]
    [Column("Id")]
    public int DepartmentId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    [Range(0, double.MaxValue)]
    public decimal Financing { get; set; } = 0;

}
