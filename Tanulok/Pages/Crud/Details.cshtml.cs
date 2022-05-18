using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tanulok.Data;
using Tanulok.Model;

namespace Tanulok.Pages.Crud
{
    public class DetailsModel : PageModel
    {
        private readonly Tanulok.Data.ApplicationDbContext _context;

        public DetailsModel(Tanulok.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Diak Diak { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Diakok == null)
            {
                return NotFound();
            }

            var diak = await _context.Diakok.FirstOrDefaultAsync(m => m.Id == id);
            if (diak == null)
            {
                return NotFound();
            }
            else 
            {
                Diak = diak;
            }
            return Page();
        }
    }
}
