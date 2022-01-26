using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediiDeProgramareProiectWeb.Models
{
    public class StartDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime _dateStart = Convert.ToDateTime(value);
            if (_dateStart >= DateTime.Now)
            {
                return ValidationResult.Success;
            }
            else            {
                return new ValidationResult(ErrorMessage);
            }
        }
    }
}
