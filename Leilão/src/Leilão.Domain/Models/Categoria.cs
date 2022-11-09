namespace Business.Models
{
    public class Categoria : Entity
    {
        public string Descricao { get; set; }
        public Produto? Produto { get; set; }

    }
}