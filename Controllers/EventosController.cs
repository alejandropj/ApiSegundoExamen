using ApiSegundoExamen.Models;
using ApiSegundoExamen.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSegundoExamen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private RepositoryEventos repo;

        public EventosController(RepositoryEventos repo)
        {
            this.repo = repo;
        }

        [HttpGet("/eventos")]
        public async Task<ActionResult<List<Evento>>>
            GetEventos()
        {
            return await this.repo.GetEventosAsync();
        }
        [HttpGet("/eventos/{id}")]
        public async Task<ActionResult<List<Evento>>>
            GetEventoByCategoria(int id)
        {
            return await this.repo.FindEventoByCat(id);
        }
        [HttpGet("/categorias")]
        public async Task<ActionResult<List<CategoriaEvento>>>
            GetCategorias()
        {
            return await this.repo.GetCategoriasAsync();
        }

    }
}
