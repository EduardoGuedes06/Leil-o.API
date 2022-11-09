using Business.Models;

namespace Leilão.Domain.Models
{
    public class Usuario : Entity
    {
        public string Email { get; set; }
        public string Senha { get; set; }

    }
}