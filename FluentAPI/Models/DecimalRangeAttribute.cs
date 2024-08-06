using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.Models
{
    public class DecimalRangeAttribute : ValidationAttribute
    {
        private readonly decimal _min;
        private readonly decimal _max;

        public DecimalRangeAttribute(double min, double max)
        {
            _min = (decimal)min;
            _max = (decimal)max;
            ErrorMessage = $"Value must be between {_min} and {_max}.";
        }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true; // Handle [Required] separately if needed
            }

            if (value is decimal decimalValue)
            {
                return decimalValue >= _min && decimalValue <= _max;
            }

            return false;
        }
    }
}
