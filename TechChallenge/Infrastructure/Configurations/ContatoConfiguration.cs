using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.Configurations
{
	public class ContatoConfiguration : IEntityTypeConfiguration<Contato>
	{
		public void Configure(EntityTypeBuilder<Contato> builder)
		{
			builder.ToTable("Contato");
			builder.HasKey(p => p.Id);
			builder.Property(p => p.Id).HasColumnType("UNIQUEIDENTIFIER").UseIdentityColumn();
			builder.Property(p => p.Nome).HasColumnType("VARCHAR(100)").IsRequired();
			builder.Property(p => p.Email).HasColumnType("VARCHAR(100)");
			builder.Property(p => p.DDD).HasColumnType("DECIMAL(2, 0)").IsRequired();
			builder.Property(p => p.Telefone).HasColumnType("VARCHAR(9)").IsRequired();
			builder.Property(p => p.DataCriacao).HasColumnType("DATETIME");
			builder.Property(p => p.DataExclusao).HasColumnType("DATETIME").HasDefaultValue(null);
		
			builder.HasOne(p => p.Regiao)
			.WithMany(c => c.Contatos)
			.HasPrincipalKey(c => c.DDD);
		}
	}
}
