using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilão.Domain.Models
{
    public class Documento
    {
        public string tipoDocumento { get; set; }
        public string anexo { get; set; }
        public DateTime dataEnvio { get; set; }

        public Documento()
        {
            dataEnvio = DateTime.Now;
        }
    }
}
