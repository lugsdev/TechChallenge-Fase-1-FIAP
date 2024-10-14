using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.Configurations
{
	public class RegiaoConfiguration : IEntityTypeConfiguration<Regiao>
	{
		public void Configure(EntityTypeBuilder<Regiao> builder)
		{
				builder.ToTable("Regiao");
				builder.HasKey(p => p.Id);
				builder.Property(p => p.Id).HasColumnType("UNIQUEIDENTIFIER").UseIdentityColumn();
				builder.Property(p => p.UF).HasColumnType("VARCHAR(2)").IsRequired();
				builder.Property(p => p.Descricao).HasColumnType("VARCHAR(100)");
				builder.Property(p => p.DDD).HasColumnType("DECIMAL(2, 0)").IsRequired();
				builder.Property(p => p.DataCriacao).HasColumnType("DATETIME");
				builder.Property(p => p.DataExclusao).HasColumnType("DATETIME").HasDefaultValue(null);
		}
	}
}
