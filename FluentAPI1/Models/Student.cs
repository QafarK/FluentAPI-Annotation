using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FluentAPI.Models;

internal class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

}
