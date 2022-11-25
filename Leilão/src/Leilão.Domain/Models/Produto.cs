using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{

    public class Produto : Entity
    {
        public Guid CategoriaId { get; set; }
        public string Nome { get; set; }

        //public string foto { get; set; }
        public string Edital { get; set; }
        public string Comitentes { get; set; }

        public string Meta { get; set; }

        public string? Acrescimo { get; set; }

        public string Natureza { get; set; }
        public Categoria Categoria { get; set; }

    }
}
