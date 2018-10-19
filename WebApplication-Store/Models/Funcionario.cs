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
        public int IDFuncionario { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        [StringLength(20, ErrorMessage = "Insira um Nome de 1 a 20 Caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Sobrenome")]
        public string Sobrenome { get; set; }

        [Display(Name = "Idade")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        public int Idade { get; set; }

        [Display(Name = "Salário")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        public decimal Salario { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        public DateTime Nascimento { get; set; }

        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Tipo de Documento")]
        public int IDTipoDocumento { get; set; }

        [Display(Name = "Número do Documento")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        public string NumeroDocumento { get; set; }


        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}