﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public abstract class Imposto
    {
        private Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }
        public Imposto()
        {
            OutroImposto = null;
        }
        protected double CalculaOutroImposto(Orcamento orcamento)
        {
            return (OutroImposto == null ? 0 : OutroImposto.Calcula(orcamento));
        }
        public abstract double Calcula(Orcamento orcamento);
    }
}
