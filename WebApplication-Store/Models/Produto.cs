using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_Store.Models
{
    public class Produto
    {
        [Key]
        public int ID { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public DateTime UltimaCompra { get; set; }

        public float Estoque { get; set; }

        public string Comentario { get; set; }

    }
}