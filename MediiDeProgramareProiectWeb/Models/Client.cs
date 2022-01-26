using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediiDeProgramareProiectWeb.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public DateTime DataNasterii { get; set; }
   }
}
