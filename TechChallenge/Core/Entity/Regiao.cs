namespace Core.Entity
{
	public class Regiao : EntityBase
	{
        public string UF { get; set; }
        public string Descricao { get; set; }
        public int DDD { get; set; }

        public ICollection<Contato> Contatos { get; set; }
    }
}
