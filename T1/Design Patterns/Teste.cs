using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{

    class Teste
    {
        static void Main(String[] args)
        {
            NotaFiscalBuilder builder = new NotaFiscalBuilder();
            builder.AdicionaAcao(new Multiplicador(2));
            builder.AdicionaAcao(new Multiplicador(3));
            builder.AdicionaAcao(new Multiplicador(5.5));

            NotaFiscal notaFiscal = builder.ParaEmpresa("Caelum")
                .ComCnpj("123.456.789/0001-10")
                .ComItem(new Item("item 1", 100.0))
                .ComItem(new Item("item 2", 200.0))
                .ComItem(new Item("item 3", 300.0))
                .ComObservacoes("entregar notaFiscal pessoalmente")
                .NaDataAtual()
                .Constroi();
        }
    }
}
