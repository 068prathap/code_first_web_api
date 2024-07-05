using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeFirstWebApi.Models;

namespace CodeFirstWebApi.Data
{
    public class CodeFirstWebApiContext : DbContext
    {
        public CodeFirstWebApiContext (DbContextOptions<CodeFirstWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<CodeFirstWebApi.Models.Product> Product { get; set; } = default!;
    }
}