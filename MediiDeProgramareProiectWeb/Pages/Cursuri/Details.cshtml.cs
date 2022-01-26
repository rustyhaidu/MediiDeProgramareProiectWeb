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
    public class DetailsModel : PageModel
    {
        private readonly MediiDeProgramareProiectWeb.Data.MediiDeProgramareProiectWebContext _context;

        public DetailsModel(MediiDeProgramareProiectWeb.Data.MediiDeProgramareProiectWebContext context)
        {
            _context = context;
        }

        public Curs Curs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Curs = await _context.Cursuri
                .Include(c => c.Antrenor)
                .Include(c => c.Client).FirstOrDefaultAsync(m => m.ID == id);

            if (Curs == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
