using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediiDeProgramareProiectWeb.Models
{
    public class Curs
    {
        public int ID { get; set; }
        [Display(Name = "Antrenor")]
        public int AntrenorID { get; set; }
        public Antrenor Antrenor { get; set; }
        [Display(Name = "Client")]
        public int ClientID { get; set; }
        public Client Client { get; set; }        
        [Display(Name = "Data Organizarii")]
        [StartDate(ErrorMessage = "Data trebuie sa fie in viitor")]
        public DateTime DataOrganizarii {get; set;}
        [Range(typeof(Int32), "1", "9",
        ErrorMessage = "Culoarul trebuie sa fie {1} intre {2}")]
        [Display(Name = "Culoarul Piscinii")]
        public int Culoar { get; set; }
    }
}
