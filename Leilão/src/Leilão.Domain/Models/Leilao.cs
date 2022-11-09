using Leilão.Domain.Models;

namespace Business.Models
{
    public class Leilao : Entity
    {
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }
        public double lanceMin { get; set; }
        public double lanceAtual {get; set;}
        TipoLeilão TipoLeilão { get; set; }
        Produto Produto { get; set; }


    }
}