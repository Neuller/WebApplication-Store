using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_Store.Models
{
    public class OrdemDetalhe
    {
        [Key]
        public int IDOrdemDetalhe { get; set; }

        public int IDProduto { get; set; }

        public int IDOrdem { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        public string Descricao { get; set; }

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Preco { get; set; }


        [Display(Name = "Quantidade")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public float Quantidade { get; set; }

        public virtual Ordem Ordem { get; set; }
        public virtual Produto Produto { get; set; }
    }
}