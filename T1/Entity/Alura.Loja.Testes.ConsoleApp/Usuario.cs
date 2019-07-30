using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Usuario
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Email { get; internal set; }
        public string Senha { get; internal set; }

        public override string ToString()
        {
            return $"Usuario: {this.Id}, {this.Nome}, {this.Senha}";
        }
    }
}