namespace AuditoriaIndustriaAutomotiva.Domain.Entities
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
