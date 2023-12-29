using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agenda.Model;

namespace agenda.Repository
{
    public interface IAgendaRepository
    {
        Task<IEnumerable<Agenda>> BuscaContatos();
        Task<Agenda> BuscaContato(int id);
        void AdicionaContato(Agenda contato);
        void AtualizaContato(Agenda contato);
        void DeletaContato(Agenda contato);

        Task<bool> SaveChangesAsync();

    }
}