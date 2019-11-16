using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDFuncionario.Models
{
    public class DepartamentoContext : DbContext
    {
        public DbSet<Departamento> Departamentos { get; set; }

        public DepartamentoContext(DbContextOptions<DepartamentoContext> options) : base(options) { }
    }
}
