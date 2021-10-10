using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RPFGOAccount.Models;

namespace RPFGOAccount.Data
{
    public class RPFGOAccountContext : DbContext
    {
        public RPFGOAccountContext (DbContextOptions<RPFGOAccountContext> options)
            : base(options)
        {
        }

        public DbSet<RPFGOAccount.Models.Character> Character { get; set; }
    }
}
