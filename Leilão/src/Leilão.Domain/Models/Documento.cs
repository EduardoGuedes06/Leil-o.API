using Business.Models;

namespace Leilão.Domain.Models
{
    public class Documento : Entity
    {
        public string TipoDocumento { get; set; }
        public string Anexo { get; set; }
        public DateTime DataEnvio { get; set; }
        public Pessoa Pessoa { get; set; }

        public Documento()
        {
            DataEnvio = DateTime.Now;
        }
    }
}
