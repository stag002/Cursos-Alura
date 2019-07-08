using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class IHIT
    {
        public override bool MesmoNome(Orcamento orcamento)
        {
            if (MesmoNome > 2)
            {
                return MesmoNome * 0.13 + 100;
            }
            else
            {
                return MesmoNome * 0.1 + NumDeItensNoOrcamento;
            }
        }
    }
}
