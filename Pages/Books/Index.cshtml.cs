using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Popica_Alexia_Lab2BUN.Data;
using Popica_Alexia_Lab2BUN.Models;

namespace Popica_Alexia_Lab2BUN.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Popica_Alexia_Lab2BUN.Data.Popica_Alexia_Lab2BUNContext _context;

        public IndexModel(Popica_Alexia_Lab2BUN.Data.Popica_Alexia_Lab2BUNContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {

            Book = await _context.Book
                .Include(b=>b.Author)
 .Include(b => b.Publisher)
 .ToListAsync();


            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
