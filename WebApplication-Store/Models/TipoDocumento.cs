using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_Store.Models
{
    public class TipoDocumento
    {
        [Key]
        public int ID { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}