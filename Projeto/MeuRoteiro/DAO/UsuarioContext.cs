using MeuRoteiro.Models;
using System.Data.Entity;

namespace MeuRoteiro.DAO
{
    public class UsuarioContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}