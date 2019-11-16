using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDFuncionario.Models
{
    public class GradeSalarioContext : DbContext
    {
        public DbSet<GradeSalario> GradeSalarios { get; set; }
        public GradeSalarioContext(DbContextOptions<GradeSalarioContext> options) : base(options) { }
    }
}
