

using System.ComponentModel.DataAnnotations;

namespace FluentAPI.Models;

public class BirthdateAfter1990Attribute : ValidationAttribute
{
    public BirthdateAfter1990Attribute()
    {
        ErrorMessage = "Birthday must be after the year 1990.";
    }

    public override bool IsValid(object value)
    {
        if (value is DateTime date)
        {

            return date.Year > 1990;
        }
        return false;
    }
}
