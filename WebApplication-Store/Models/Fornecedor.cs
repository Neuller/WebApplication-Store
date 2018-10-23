using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_Store.Models
{
    public class Fornecedor
    {
        [Key]
        public int IDFornecedor { get; set; }

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
        public string Email { get; set; }

        public virtual ICollection<FornecedorProduto> FornecedorProduto { get; set; }
    }
}
