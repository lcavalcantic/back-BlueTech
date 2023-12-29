using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agenda.Data;
using agenda.Model;
using Microsoft.EntityFrameworkCore;

namespace agenda.Repository
{
    public class AgendaRepository : IAgendaRepository
    {
        private readonly AgendaContext context;
        public AgendaRepository(AgendaContext context)
        {
            this.context = context;
        }
        public void AdicionaContato(Agenda contato)
        {
            this.context.Add(contato);
        }

        public void AtualizaContato(Agenda contato)
        {
           this.context.Update(contato);
        }

        public async Task<Agenda> BuscaContato(int id)
        {
            return await this.context.Contatos.
                   Where(x  => x.Id ==id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Agenda>> BuscaContatos()
        {
            return await this.context.Contatos.ToListAsync();
        }

        public void DeletaContato(Agenda contato)
        {
            this.context.Remove(contato);

        }
        public async Task<bool> SaveChangesAsync(){
            return await this.context.SaveChangesAsync() > 0;
        } 
    }
}