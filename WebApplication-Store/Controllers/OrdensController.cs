using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_Store.Models;
using WebApplication_Store.ViewModels;

namespace WebApplication_Store.Controllers
{
    public class OrdensController : Controller
    {

        private WebApplication_StoreContext db = new WebApplication_StoreContext();

        // GET: Ordens
        public ActionResult NovaOrdem()
        {
            var ordemView = new OrdemView();
            ordemView.Customizar = new Customizar();
            ordemView.Produtos = new List<ProdutoOrdem>();

            Session["OrdemView"] = ordemView;     

            var List = db.Customizars.ToList();
            List.Add(new Customizar { IDCustomizar = 0, Nome = "[Selecione um Cliente]" });
            List = List.OrderBy(c => c.NomeCompleto).ToList();
            ViewBag.IDCustomizar = new SelectList(List, "IDCustomizar", "NomeCompleto");

            return View(ordemView);
        }

        [HttpPost]
        public ActionResult NovaOrdem(OrdemView ordemView)
        {
            ordemView = Session["OrdemView"] as OrdemView;
            var IDCustomizar = int.Parse(Request["IDCustomizar"]);
            var List = db.Customizars.ToList();

            if (IDCustomizar == 0)
            {
                List.Add(new Customizar { IDCustomizar = 0, Nome = "[Selecione um Cliente]" });
                List = List.OrderBy(c => c.NomeCompleto).ToList();
                ViewBag.IDCustomizar = new SelectList(List, "CustomizarID", "NomeCompleto");
                ViewBag.Error = "Selecione um Cliente";

                return View(ordemView);
            }

            var Cliente = db.Customizars.Find(IDCustomizar);

            if (Cliente == null)
            {
                List.Add(new Customizar { IDCustomizar = 0, Nome = "[Selecione um Cliente]" });
                List = List.OrderBy(c => c.NomeCompleto).ToList();
                ViewBag.IDCustomizar = new SelectList(List, "CustomizarID", "NomeCompleto");
                ViewBag.Error = "Não existe o Cliente Selecionado";

                return View(ordemView);
            }

            if(ordemView.Produtos.Count == 0)
            {
                List.Add(new Customizar { IDCustomizar = 0, Nome = "[Selecione um Cliente]" });
                List = List.OrderBy(c => c.NomeCompleto).ToList();
                ViewBag.IDCustomizar = new SelectList(List, "CustomizarID", "NomeCompleto");
                ViewBag.Error = "Selecione um Produto";

                return View(ordemView);
            }

            var ordem = new Ordem
            {
                IDCustomizar = IDCustomizar,
                OrdemData = DateTime.Now, 
                OrdemStatus = OrdemStatus.Criada
            };

            db.Ordem.Add(ordem);
            db.SaveChanges();

            var ordemID = db.Ordem.ToList().Select(o => o.IDOrdem).Max();

            foreach (var item in ordemView.Produtos)
            {
                var ordemDetalhe = new OrdemDetalhe
                {
                    IDProduto = item.IDProduto,
                    Descricao = item.Descricao,
                    Quantidade = item.Quantidade,
                    Preco = item.Preco,
                    IDOrdem = ordemID
                };

                db.OrdemDetalhe.Add(ordemDetalhe);
                db.SaveChanges();

            }

            ViewBag.Mensagem = string.Format("Ordem: {0}, Salva com Sucesso!", ordemID);

            List.Add(new Customizar { IDCustomizar = 0, Nome = "[Selecione um Cliente]" });
            List = List.OrderBy(c => c.NomeCompleto).ToList();
            ViewBag.IDCustomizar = new SelectList(List, "CustomizarID", "NomeCompleto");

            ordemView = new OrdemView();
            ordemView.Customizar = new Customizar();
            ordemView.Produtos = new List<ProdutoOrdem>();

            Session["OrdemView"] = ordemView;

            return View();
        }

        public ActionResult AddProduto()
        {
            
            var List = db.Produtoes.ToList();
            List.Add(new ProdutoOrdem { IDProduto = 0, Descricao = "[Selecione um Produto]" });
            List = List.OrderBy(c => c.Descricao).ToList();
            ViewBag.IDProduto = new SelectList(List, "IDProduto", "Descricao");

            return View();
        }

        [HttpPost]
        public ActionResult AddProduto(ProdutoOrdem produtoOrdem)
        {     
            var ordemView = Session["OrdemView"] as OrdemView;
            var produtoID = int.Parse(Request["IDProduto"]);
            var List = db.Produtoes.ToList();

            if(produtoID == 0)
            {
                List.Add(new ProdutoOrdem { IDProduto = 0, Descricao = "[Selecione um Produto]" });
                List = List.OrderBy(c => c.Descricao).ToList();
                ViewBag.IDProduto = new SelectList(List, "IDProduto", "Descricao");
                ViewBag.Error = "Selecione um Produto";

                return View(produtoOrdem);
            }

            var produto = db.Produtoes.Find(produtoID);

            if (produto == null)
            {
                List.Add(new ProdutoOrdem { IDProduto = 0, Descricao = "[Selecione um Produto]" });
                List = List.OrderBy(c => c.Descricao).ToList();
                ViewBag.IDProduto = new SelectList(List, "IDProduto", "Descricao");
                ViewBag.Error = "Não existe o Produto Selecionado";

                return View(produtoOrdem);
            }

            produtoOrdem = ordemView.Produtos.Find(p => p.IDProduto == produtoID);
            if (produtoOrdem == null)
            {

                produtoOrdem = new ProdutoOrdem
                {
                    Descricao = produto.Descricao,
                    Preco = produto.Preco,
                    IDProduto = produto.IDProduto,
                    Quantidade = float.Parse(Request["Quantidade"])
                };
                ordemView.Produtos.Add(produtoOrdem);
            }else
            {
                produtoOrdem.Quantidade += float.Parse(Request["Quantidade"]);
            }
           
            var ListCliente = db.Customizars.ToList();
            ListCliente.Add(new Customizar { IDCustomizar = 0, Nome = "[Selecione um Cliente]" });
            ListCliente = ListCliente.OrderBy(c => c.NomeCompleto).ToList();
            ViewBag.IDCustomizar = new SelectList(ListCliente, "IDCustomizar", "NomeCompleto");

            return View("NovaOrdem", ordemView);

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}