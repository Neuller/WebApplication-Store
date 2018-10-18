using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_Store.Models
{
    public class Funcionario
    {
        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public int Idade { get; set; }

        public decimal Salario { get; set; }

        public DateTime Nascimento { get; set; }

        public DateTime DataCadastro { get; set; }

        public string Email { get; set; }


        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}