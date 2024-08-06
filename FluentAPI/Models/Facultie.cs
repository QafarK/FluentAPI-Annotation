using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI.Models;

[Index(nameof(Name),IsUnique = true, Name = "UQ_Faculties_Name")]
internal class Facultie
{
    [Key]
    [Required]
    [Column("Id")]
    public int FacultyId { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

}
