using agenda.Model;
using Microsoft.EntityFrameworkCore;

namespace agenda.Data
{
    public class AgendaContext : DbContext
    {
        public DbSet<Agenda> Contatos { get; set; }

        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var contato = modelBuilder.Entity<Agenda>();

            contato.ToTable("tb_contatos");
            contato.HasKey(x => x.Id).HasName("PK_Contatos");
            contato.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            contato.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            contato.Property(x => x.Telefone).HasColumnName("telefone").IsRequired();
            contato.Property(x => x.Email).HasColumnName("email").IsRequired();
        }
    }
}
