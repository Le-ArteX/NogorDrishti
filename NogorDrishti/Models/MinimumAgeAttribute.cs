using System.ComponentModel.DataAnnotations;
namespace NogorDrishti.Models
{
    public class MinimumAgeAttribute : ValidationAttribute
    {
        public readonly int _MinimumAge;

        public MinimumAgeAttribute(int minimumAge)
        {
            _MinimumAge = minimumAge;
        }
        public override bool IsValid(object value)
        {
            if (value is DateTime dateOfBirth)
            {
                var today = DateTime.Today;
                var age = today.Year - dateOfBirth.Year;
                if (dateOfBirth > today.AddYears(-age))
                {
                    age--;
                }
                return age >= _MinimumAge;
            }
            return false;
        }

    }
}
