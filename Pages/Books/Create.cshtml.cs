using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mititean_Ionut_Daniel_Lab2.Data;
using Mititean_Ionut_Daniel_Lab2.Models;

namespace Mititean_Ionut_Daniel_Lab2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Mititean_Ionut_Daniel_Lab2.Data.Mititean_Ionut_Daniel_Lab2Context _context;

        public CreateModel(Mititean_Ionut_Daniel_Lab2.Data.Mititean_Ionut_Daniel_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            // Key changed to "Author" to match the Razor view (asp-items="ViewBag.Author")
            ViewData["AuthorID"] = new SelectList(_context.Set<Author>(), "ID", "LastName");
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID", "PublisherName");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
