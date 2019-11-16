using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDFuncionario.Models
{
    [Table("tb_grade_salario")]
    public class GradeSalario
    {
        [Key]
        public int Id_salario { get; set; }
        public decimal Min_salario { get; set; }
        public decimal Max_salario { get; set; }
        public int Fg_ativo { get; set; }
    }
}
