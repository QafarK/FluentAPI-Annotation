
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FluentAPI.Models;

internal class Group
{
    [Key]
    [Required]
    [Column("Id")]
    public int GroupId { get; set; }

    [Required]
    [MaxLength(10)]
    public string Name { get; set; }

    [Range(0, 5)]
    public int Rating { get; set; }

    [Range(1, 4)]
    public int Year { get; set; }

}
