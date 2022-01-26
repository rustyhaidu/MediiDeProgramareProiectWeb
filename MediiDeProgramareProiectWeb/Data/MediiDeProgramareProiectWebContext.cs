using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MediiDeProgramareProiectWeb.Models;

namespace MediiDeProgramareProiectWeb.Data
{
    public class MediiDeProgramareProiectWebContext : DbContext
    {
        public MediiDeProgramareProiectWebContext (DbContextOptions<MediiDeProgramareProiectWebContext> options)
            : base(options)
        {
        }

        public DbSet<MediiDeProgramareProiectWeb.Models.Antrenor> Antrenor { get; set; }

        public DbSet<MediiDeProgramareProiectWeb.Models.Client> Client { get; set; }

        public DbSet<MediiDeProgramareProiectWeb.Models.Curs> Cursuri { get; set; }
    }
}
