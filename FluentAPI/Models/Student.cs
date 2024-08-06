using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FluentAPI.Models;

internal class Student
{
    [Key]
    [Required]
    [Column("Id")]
    public int StudentId { get; set; }

    [Required]
    [MaxLength(int.MaxValue)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(int.MaxValue)]
    public string LastName { get; set; }

}
