using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDFuncionario.Models
{
    [Table("tb_funcionario")]
    public class Funcionario
    {
        [Key]
        public int Id_funcionario { get; set; }
        public int Id_gerente { get; set; }

        [ForeignKey("tb_departamento")]
        [Column("id_departamento")]
        public int Id_departamento { get; set; }
        public DateTime Dt_nascimento { get; set; }
        public Decimal Salario { get; set; }
        public string Cargo { get; set; }
        public int Fg_ativo { get; set; }

        public virtual Departamento Departamento { get; set; }
    }
}
