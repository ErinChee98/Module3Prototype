using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Module3Prototype.Models;

namespace Module3Prototype.Data
{
    public class Module3PrototypeContext : DbContext
    {
        public Module3PrototypeContext (DbContextOptions<Module3PrototypeContext> options)
            : base(options)
        {
        }

        public DbSet<Module3Prototype.Models.Module> Module { get; set; }
    }
}
