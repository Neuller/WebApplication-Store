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
        public int IDTipoDocumento { get; set; }

        [Display(Name = "Tipo de Documento")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        public string Descricao { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }

        public virtual ICollection<Customizar> Customizar { get; set; }
    }
}