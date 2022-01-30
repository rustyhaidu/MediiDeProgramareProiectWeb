using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MediiDeProgramareProiectWeb.Data;
using MediiDeProgramareProiectWeb.Models;

namespace MediiDeProgramareProiectWeb.Pages.Cursuri
{
    public class EditModel : PageModel
    {
        private readonly MediiDeProgramareProiectWeb.Data.MediiDeProgramareProiectWebContext _context;

        public EditModel(MediiDeProgramareProiectWeb.Data.MediiDeProgramareProiectWebContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["AntrenorID"] = new SelectList(_context.Antrenor, "ID", "Nume");
           ViewData["ClientID"] = new SelectList(_context.Client, "ID", "Nume");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Curs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursExists(Curs.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CursExists(int id)
        {
            return _context.Cursuri.Any(e => e.ID == id);
        }
    }
}
