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
    public class IndexModel : PageModel
    {
        private readonly Tanulok.Data.ApplicationDbContext _context;

        public IndexModel(Tanulok.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Diak> Diak { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Diakok != null)
            {
                Diak = await _context.Diakok.ToListAsync();
            }
        }
    }
}
