using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_de_Console
{

    public class Diretor
    {
        public string Nome = "Roberta";
        public string CPF = "454.658.148-3";
        public double Salario = 5000;
        public class GerenciadorBonificacao
        {

            private double _totalBonificacao;
            public void Registrar(Funcionario funcionarios)
            {
                _totalBonificacao += funcionarios.GetBonificacao();
            }
            public void Registrar(Diretor diretor)
            {
                _totalBonificacao += diretor.GetBonificacao();
            }

            private double GetBonificacao()
            {
                return _totalBonificacao;
            }
        }
    }
}
