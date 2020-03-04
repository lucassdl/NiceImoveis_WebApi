using NiceImoveis_WebApi.Domain.Entities;
using System.Data.Entity;

namespace NiceImoveis_WebApi.Infra.Config
{
    public class Context : DbContext
    {
        public Context():base("DefaultConnection")
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
