using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace FluentAPI.Models;

internal class Department
{
    public int DepartmentId { get; set; }

    public string Name { get; set; }

    public decimal Financing { get; set; } = 0;

}
