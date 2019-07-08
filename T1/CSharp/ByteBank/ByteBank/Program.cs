using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            Console.ReadLine();
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("888.888.888-24");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("999.999.999-24");
            roberta.Nome = "Roberta";
            
            Funcionario igor = new Auxiliar("666.666.666-24");
            igor.Nome = "Igor";
            
            Desenvolvedor guilherme = new Desenvolvedor("777.777.777-24");
            guilherme.Nome = "Guilherme";
            
            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
        
            Console.WriteLine("Total de bonificação do mês" + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}