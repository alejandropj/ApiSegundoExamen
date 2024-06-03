using ApiSegundoExamen.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSegundoExamen.Data
{
    public class EventosContext:DbContext
    {
        public EventosContext(DbContextOptions<EventosContext> options)
            : base(options) { }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<CategoriaEvento> CategoriasEventos { get; set; }
    }
}
