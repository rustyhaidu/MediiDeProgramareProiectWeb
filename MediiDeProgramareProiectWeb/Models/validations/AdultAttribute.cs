using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediiDeProgramareProiectWeb.Models
{
    public class AdultAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime _dateStart = Convert.ToDateTime(value);
            TimeSpan span = DateTime.Now - _dateStart;
            int years = (zeroTime + span).Year - 1;
            if (years >= 18)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(ErrorMessage);
            }
        }
    }
}
