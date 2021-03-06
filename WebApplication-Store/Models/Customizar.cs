﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_Store.Models
{
    public class Customizar
    {
        [Key]
        public int IDCustomizar { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        public string Nome { get; set; }

        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        public string Sobrenome { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        public string Telefone { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        public string Endereco { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public int IDTipoDocumento { get; set; }

        [Display(Name = "Número do Documento")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        public string NumeroDocumento { get; set; }

        public string NomeCompleto { get { return string.Format("{0} {1}", Nome, Sobrenome); } }

        public virtual TipoDocumento TipoDocumento { get; set; }
        public virtual ICollection<Ordem> Ordem { get; set; }
    }
}