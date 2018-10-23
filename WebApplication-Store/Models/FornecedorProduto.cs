using System.ComponentModel.DataAnnotations;

namespace WebApplication_Store.Models
{
    public class FornecedorProduto
    {
        [Key]
        public int IDFornecedorProduto { get; set; }

        public int IDFornecedor { get; set; }

        public int IDProduto { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }

        public virtual Produto Produto { get; set; }

    }
}