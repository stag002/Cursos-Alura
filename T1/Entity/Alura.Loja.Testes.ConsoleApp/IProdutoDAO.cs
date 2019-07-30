using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    interface IProdutoDAO
    {
        void Adicionar(Usuario u);
        void Atualizar(Usuario u);
        void Remover(Usuario u);
        IList<Usuario> Usuarios();
    }
}
