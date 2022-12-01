using Leilão.Domain.Models;

namespace Business.Models
{
    public class Leilao : Entity
    {
        public Guid produtoId { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }
        public double lanceMin { get; set; }
        public double lanceAtual {get; set;}
        public TipoLeilão TipoLeilão { get; set; }
        public Produto Produto { get; set; }


    }
}