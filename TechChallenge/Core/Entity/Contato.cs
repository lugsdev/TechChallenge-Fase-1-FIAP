namespace Core.Entity
{
	public class Contato : EntityBase
	{
        public required string Nome { get; set; }
		public string? Email { get; set; }
        public required int DDD { get; set; }
        public required string Telefone { get; set; }

        public Regiao Regiao { get; set; }
    }
}
