using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediiDeProgramareProiectWeb.Models
{
    public class Client
    {
        public int ID { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,40}$",
        ErrorMessage = "Doar literele sunt permise, min = 3, max = 40"), Required]
        public string Nume { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,40}$",
        ErrorMessage = "Doar literele sunt permise, min = 3, max = 40"), Required]
        public string Prenume { get; set; }
        [RegularExpression(@"^[0-9''-'\s]{13,13}$",
        ErrorMessage = "Doar numere, 13 caractere obligatoriu"), Required]
        public string CNP { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data Nasterii")]
        [Adult(ErrorMessage = "Trebuie sa fii adult")]
        
        public DateTime DataNasterii { get; set; }
   }
}
