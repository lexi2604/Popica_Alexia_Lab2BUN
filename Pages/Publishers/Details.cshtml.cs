using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Popica_Alexia_Lab2BUN.Data;
using Popica_Alexia_Lab2BUN.Models;

namespace Popica_Alexia_Lab2BUN.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Popica_Alexia_Lab2BUN.Data.Popica_Alexia_Lab2BUNContext _context;

        public DetailsModel(Popica_Alexia_Lab2BUN.Data.Popica_Alexia_Lab2BUNContext context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
