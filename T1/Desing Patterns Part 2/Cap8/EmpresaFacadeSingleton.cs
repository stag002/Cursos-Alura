using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap8
{
    private static EmpresaFacade instancia = new EmpresaFacade();

    public EmpresaFacade Instancia
    {
        get
        {
            return instancia;
        }
    }
}
