using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public EstadoDeUmOrcamento EstadoAtual { get; set; }
        public Orcamento()
        {
            this.EstadoAtual = new EmAprovacao();
        }
        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }
        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }
        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }
         public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
