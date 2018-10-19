using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_Store.Models
{
    public class Produto
    {
        [Key]
        public int IDProduto { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        public string Descricao { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        public decimal Preco { get; set; }

        [Display(Name = "Última Compra")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        public DateTime UltimaCompra { get; set; }

        [Display(Name = "Estoque")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        public float Estoque { get; set; }

        [Display(Name = "Comentário")]
        public string Comentario { get; set; }

    }
}