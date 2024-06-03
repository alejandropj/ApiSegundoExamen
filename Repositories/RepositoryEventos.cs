using ApiSegundoExamen.Data;
using ApiSegundoExamen.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSegundoExamen.Repositories
{
    public class RepositoryEventos
    {
        private EventosContext context;
        public RepositoryEventos(EventosContext context)
        {
            this.context = context;
        }

        public async Task<List<Evento>> GetEventosAsync()
        {
            return await this.context.Eventos.ToListAsync();
        }
        public async Task<List<CategoriaEvento>> GetCategoriasAsync()
        {
            return await this.context.CategoriasEventos.ToListAsync();
        }
        public async Task<List<Evento>> FindEventoByCat(int idCategoria)
        {
            return await this.context.Eventos.Where
                (x => x.IdCategoria == idCategoria).ToListAsync();
        }
    }
}
