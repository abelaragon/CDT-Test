using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCGP.Models;

namespace MVCGP.Data
{
    public class MVCGPContext : DbContext
    {
        public MVCGPContext (DbContextOptions<MVCGPContext> options)
            : base(options)
        {
        }

        public DbSet<MVCGP.Models.Producto> Producto { get; set; }

        public DbSet<MVCGP.Models.Semanas> Semanas { get; set; }

        public DbSet<MVCGP.Models.Cotizar> Cotizar { get; set; }
    }
}
