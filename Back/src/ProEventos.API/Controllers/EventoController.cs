using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento(){
                EventoID = 1,
                Tema = "Angular e .NET",
                Local = "BH",
                DataEvento = DateTime.Now.AddDays(2).ToString()        
                },
                new Evento(){    
                EventoID = 2,
                Tema = "Angular 2",
                Local = "BH 2.0",
                DataEvento = DateTime.Now.AddDays(2).ToString()  
            }  
                   
        };
        
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoID == id );
        }

        [HttpPost]
        public String Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public String Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public String Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
