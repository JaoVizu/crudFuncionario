using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDFuncionario.Models
{
    [Table("tb_departamento")]
    public class Departamento
    {
        [Key]
        public int Id_departamento { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public int Fg_ativo { get; set; }
    }
}
