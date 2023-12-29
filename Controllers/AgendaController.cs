using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agenda.Model;
using agenda.Repository;
using Microsoft.AspNetCore.Mvc;

namespace agenda.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendaController : ControllerBase
    {
        private readonly IAgendaRepository repository;

        public AgendaController(IAgendaRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var contatos = await this.repository.BuscaContatos();
            return contatos.Any()
                ? Ok(contatos)
                : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPorId(int id)
        {
            var contato = await this.repository.BuscaContato(id);
            return contato != null
                ? Ok(contato)
                : NotFound("Contato não encontrado");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Agenda contato)
        {
           this.repository.AdicionaContato(contato);
           return await this.repository.SaveChangesAsync()
                ? Ok("Contato adicionado com sucesso")
                : BadRequest("Erro ao adicionar contato");


        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Agenda contato)
        {
            var contatoBanco = await this.repository.BuscaContato(id);
            if(contatoBanco == null) return NotFound("Contato não encontrado");

            contatoBanco.Nome = contato.Nome ?? contatoBanco.Nome;
            contatoBanco.Email = contato.Email ?? contatoBanco.Email;
            contatoBanco.Telefone = contato.Telefone ?? contatoBanco.Telefone;

            this.repository.AtualizaContato(contatoBanco);
            
            return await this.repository.SaveChangesAsync()
            ? Ok("Contato atualizado com sucesso")
            : BadRequest("Erro ao atualizar o contato");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var contatoBanco = await this.repository.BuscaContato(id);
            if(contatoBanco == null) return NotFound("Contato não encontrado");


            this.repository.DeletaContato(contatoBanco);

            return await this.repository.SaveChangesAsync()
            ? Ok("Contato deletado com sucesso")
            : BadRequest("Erro ao deletar o contato");
        }

      }
    }
    
