using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MediiDeProgramareProiectWeb.Data;
using MediiDeProgramareProiectWeb.Models;

namespace MediiDeProgramareProiectWeb.Pages.Cursuri
{
    public class IndexModel : PageModel
    {
        private readonly MediiDeProgramareProiectWeb.Data.MediiDeProgramareProiectWebContext _context;

        public IndexModel(MediiDeProgramareProiectWeb.Data.MediiDeProgramareProiectWebContext context)
        {
            _context = context;
        }

        public IList<Curs> Curs { get;set; }

        public async Task OnGetAsync()
        {
            Curs = await _context.Cursuri
                .Include(c => c.Antrenor)
                .Include(c => c.Client).ToListAsync();
        }
    }
}
