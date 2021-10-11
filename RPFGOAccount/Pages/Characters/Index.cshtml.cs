using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RPFGOAccount.Data;
using RPFGOAccount.Models;

namespace RPFGOAccount.Pages.Characters
{
    public class IndexModel : PageModel
    {
        private readonly RPFGOAccount.Data.RPFGOAccountContext _context;

        public IndexModel(RPFGOAccount.Data.RPFGOAccountContext context)
        {
            _context = context;
        }

        public IList<Character> Character { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Class { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CharacterClass { get; set; }
        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Character
                                            orderby m.Class
                                            select m.Class;

            var movies = from m in _context.Character
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Name.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(CharacterClass))
            {
                movies = movies.Where(x => x.Class == CharacterClass);
            }
            Class = new SelectList(await genreQuery.Distinct().ToListAsync());
            Character = await movies.ToListAsync();
        }
    }
}
