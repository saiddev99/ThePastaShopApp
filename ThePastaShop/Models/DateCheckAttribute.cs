using System.ComponentModel.DataAnnotations;

namespace ThePastaShop.Models
{
    public class DateCheckAttribute: ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null)
            {
                return true;
            }
            return ((DateTime)value) < DateTime.Now;
        }
    }
}
