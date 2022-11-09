using Business.Models;

namespace Leilão.Domain.Models
{
    public class Pessoa : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public Documento Documento { get; set; }
    }
}