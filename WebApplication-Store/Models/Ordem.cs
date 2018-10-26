using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_Store.Models
{
    public class Ordem
    {
        [Key]
        public int IDOrdem { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessage = "Você precisa preenhcer o campo {0}")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        //[DataType(DataType.Date)]
        public DateTime OrdemData { get; set; }

        public int IDCustomizar { get; set; }

        public OrdemStatus OrdemStatus { get; set; }

        public virtual Customizar Customizar { get; set; }

        public virtual ICollection<OrdemDetalhe> OrdemDetalhe { get; set; }
    }
}