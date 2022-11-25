using Business.Models;

namespace Leilão.Domain.Models
{
    public class Usuario : Entity
    {
        public string cpf { get; set; }
        public string Senha { get; set; }

        public IEnumerable<Lance> lances { get; set; }
        

    }
}