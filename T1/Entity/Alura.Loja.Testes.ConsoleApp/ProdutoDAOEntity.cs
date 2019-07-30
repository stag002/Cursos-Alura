using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class ProdutoDAOEntity : IProdutoDAO, IDisposable
    {
        private UsuarioContext contexto;

        public ProdutoDAOEntity()
        {
            this.contexto = new UsuarioContext();
        }

        public void Adicionar(Usuario u)
        {
            contexto.Nome.Add(u);
            contexto.SaveChanges();
        }

        public void Atualizar(Usuario u)
        {
            contexto.Nome.Update(u);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Usuario> Usuarios()
        {
            return contexto.Nome.ToList();
        }

        public void Remover(Usuario u)
        {
            contexto.Nome.Remove(u);
            contexto.SaveChanges();
        }
    }
}
