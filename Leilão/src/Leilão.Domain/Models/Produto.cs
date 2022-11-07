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
        public string edital { get; set; }
        public string comitentes { get; set; }

        public string meta { get; set; }

        public string acressimo { get; set; }

        public string natureza { get; set; }
        public Categoria Categoria { get; set; }

    }
}
