using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediiDeProgramareProiectWeb.Models
{
    public class Curs
    {
        public int ID { get; set; }
        public int AntrenorID { get; set; }
        public Antrenor Antrenor { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public DateTime DataOrganizarii {get; set;}
        public int Culoar { get; set; }
    }
}
