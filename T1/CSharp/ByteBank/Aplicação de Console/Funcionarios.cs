using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_de_Console
{
    public class Funcionario
    {
        public string Nome = "Carlos";
        public string CPF = "546.879.157-20";
        public double Salario = 2000;


        public class GerenciadorBonificacao
        {
            private double _totalBonificacao;

            public void Registrar(Funcionario funcionario)
            {
                _totalBonificacao += funcionario.GetBonificacao();
            }

            public void Registrar(Diretor diretor)
            {
                _totalBonificacao += diretor.GetBonificacao();
            }

            public double GetTotalBonificacao()
            {
                return _totalBonificacao;
            }
        }
    }
}
