﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) { }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de reprovação, não pode aprovar agora!");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Já estou reprovado!");
        }
        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
