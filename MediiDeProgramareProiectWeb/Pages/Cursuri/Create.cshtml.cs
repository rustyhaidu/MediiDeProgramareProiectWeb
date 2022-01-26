using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MediiDeProgramareProiectWeb.Data;
using MediiDeProgramareProiectWeb.Models;

namespace MediiDeProgramareProiectWeb.Pages.Cursuri
{
    public class CreateModel : PageModel
    {
        private readonly MediiDeProgramareProiectWeb.Data.MediiDeProgramareProiectWebContext _context;

        public CreateModel(MediiDeProgramareProiectWeb.Data.MediiDeProgramareProiectWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AntrenorID"] = new SelectList(_context.Antrenor, "ID", "Nume");
        ViewData["ClientID"] = new SelectList(_context.Client, "ID", "Nume");
            return Page();
        }

        [BindProperty]
        public Curs Curs { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cursuri.Add(Curs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
