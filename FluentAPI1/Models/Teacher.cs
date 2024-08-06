using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace FluentAPI.Models;

internal class Teacher
{
    public int TeacherId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime EmploymentDate { get; set; }
    public decimal Premium { get; set; } = 0;
    public decimal Salary { get; set; } = 0;



}
