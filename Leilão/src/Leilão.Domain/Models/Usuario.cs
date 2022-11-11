using Business.Models;

namespace Leilão.Domain.Models
{
    public class Usuario : Entity
    {
        public string cpf { get; set; }
        public string Senha { get; set; }
        //public PessoaFisica? pessoaF { get; set; }
        //public PessoaJuridica? pessoaJ { get; set; }
        public 
        public IEnumerable<Lance> lances { get; set; }
        

    }
}