using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppWebBootstrap.Models;

namespace AppWebBootstrap.Data
{
    public class AppWebBootstrapContext : DbContext
    {
        public AppWebBootstrapContext (DbContextOptions<AppWebBootstrapContext> options)
            : base(options)
        {
        }

        public DbSet<AppWebBootstrap.Models.Logradouro> Logradouro { get; set; }

        public DbSet<AppWebBootstrap.Models.Aluno> Aluno { get; set; }
    }
}
