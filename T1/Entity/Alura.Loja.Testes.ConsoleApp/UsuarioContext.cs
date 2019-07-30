using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Loja.Testes.ConsoleApp
{
    internal class UsuarioContext : DbContext
    {
        public DbSet<Usuario> Nome { get; set; }
        public DbSet<Usuario> Email { get; set; }
        public DbSet<Usuario> Senha { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
        }
    }
}