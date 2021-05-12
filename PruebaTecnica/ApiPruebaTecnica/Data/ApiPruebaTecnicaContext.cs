using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Models;

namespace ApiPruebaTecnica.Data
{
    public class ApiPruebaTecnicaContext : DbContext
    {
        public ApiPruebaTecnicaContext (DbContextOptions<ApiPruebaTecnicaContext> options)
            : base(options)
        {
        }

        public DbSet<PruebaTecnica.Models.User> User { get; set; }
    }
}
