using BlazorApp1.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using supports.Models;

namespace BlazorApp1.Pages
{


    public class IndexModel(ApplicationDbContext _db) : PageModel
    {
        [BindProperty]
        public Company company { get; set; }

        public ActionResult OnGet()
        {

            return Ok(_db.Companies);
        }

        private ActionResult Ok(DbSet<Company> companies)
        {
            throw new NotImplementedException();
        }

        public IActionResult OnPost()
        {
            _db.Companies.Add(company);
            _db.SaveChanges();
            return RedirectToPage("index");
        }
    }

}
