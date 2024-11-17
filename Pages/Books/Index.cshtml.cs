using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sovrea_Cornel_Lab2.Data;
using Sovrea_Cornel_Lab2.Models;

namespace Sovrea_Cornel_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Sovrea_Cornel_Lab2.Data.Sovrea_Cornel_Lab2Context _context;

        public IndexModel(Sovrea_Cornel_Lab2.Data.Sovrea_Cornel_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher).ToListAsync();
        }
    }
}
