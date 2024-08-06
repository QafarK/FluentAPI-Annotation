
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FluentAPI.Models;

internal class Group
{

    public int GroupId { get; set; }
    public string Name { get; set; }
    public int Rating { get; set; }
    public int Year { get; set; }

}
