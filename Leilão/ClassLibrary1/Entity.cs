namespace Leilao.Entity
{
    public abstract class EntityModel
    {
        protected EntityModel()
        {
            Id = Guid.NewGuid();

            DataCadastro = DateTime.Now;

        }


        public DateTime DataCadastro { get; set; }
        public Guid Id { get; set; }
    }
}