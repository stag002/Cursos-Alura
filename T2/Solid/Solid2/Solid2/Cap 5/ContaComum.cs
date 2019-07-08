using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid2.Cap_5
{
    public class ContaComum
    {
        public void Saca(double valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
            }
            else
            {
                throw new ArgumentException();
            }
        }
            public virtual void somaInvestimento()
            {
            this.Saldo += this.Saldo * 0.01;
            }
        
    }
}
