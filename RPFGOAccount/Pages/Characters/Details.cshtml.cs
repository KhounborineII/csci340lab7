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
    public class DetailsModel : PageModel
    {
        private readonly RPFGOAccount.Data.RPFGOAccountContext _context;

        public DetailsModel(RPFGOAccount.Data.RPFGOAccountContext context)
        {
            _context = context;
        }

        public Character Character { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Character = await _context.Character.FirstOrDefaultAsync(m => m.ID == id);

            if (Character == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
