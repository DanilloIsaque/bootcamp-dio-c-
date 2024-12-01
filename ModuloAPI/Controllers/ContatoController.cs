using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Entities;

namespace ModuloAPI.Controllers
{
     [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {

        private readonly AgendaContext _context; // acessar o banco

        public ContatoController (AgendaContext context){
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato){
            _context.Add(contato);
            _context.SaveChanges(contato);
            return CreateAtAction(nameof(ObterPorId), new {id = contato.Id} , contato); // cria o recurso e mostra o endereço aonde ficará localizado
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id){
            var contato = _context.contatos.Find(id);

            if(contato == null){
                return NotFound();
            }

            return Ok(contato);
        }    

         [HttpGet("ObterPorNome")]
        public IActionResult ObterPorId(string nome){
            var contatosPorNome = _context.contatos.Where(x=>x.Nome.Contains(nome));
            return Ok(contatosPorNome);
        } 

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato){
            var contatoBanco = _context.contatos.Find(id);
            
            if(contatoBanco == null){
                return NotFound();
            }

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.contatos.Update(contatoBanco);
            _context.SaveChanges(contatoBanco);
            return Ok(contatoBanco);
        
        }      

          [HttpDelete("{id}")]
        public IActionResult Excluir(int id){
            var contato = _context.contatos.Find(id);

            if(contato == null){
                return NotFound();
            }

            _context.contatos.Remove(contato);
             _context.SaveChanges(contato);
            return Ok(contato);
        }  
    }
}