using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public async Task OnGetAsync()
        {
            Character = await _context.Character.ToListAsync();
        }
    }
}
