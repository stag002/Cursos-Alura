using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_de_Console
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario fucionario)
        {
            _totalBonificacao += Funcionario.GetBonificacao();
        }
        public void Registrar(Diretor diretor)
        {
            _totalBonificacao += Diretor.GetBonificacao();
        }
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
