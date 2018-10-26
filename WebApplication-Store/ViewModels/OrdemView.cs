using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication_Store.Models;

namespace WebApplication_Store.ViewModels
{
    public class OrdemView
    {
        public Customizar Customizar { get; set; }

        public ProdutoOrdem Produto { get; set; }

        public List<ProdutoOrdem> Produtos { get; set; }

    }
}