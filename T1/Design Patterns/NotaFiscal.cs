using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class NotaFiscal
    {
        private String RazaoSocial { get; set; }
        private String Cnpj { get; set; }
        private List<ItemDaNota> todosItens = new ArrayList<ItemDaNota>();
        private double ValorBruto { get; set; }
        private double Impostos { get; set; }
        private String Observacoes { get; set; }
        private DateTime Data { get; set; }

        public NotaFiscal ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscal ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscal Com(Item novo)
        {
            todosItens.Add(novo);
            ValorBruto += novo.Valor;
            Impostos += novo.Valor * 0.05;

            return this;
        }

        public NotaFiscal ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;

            return this;
        }

        public NotaFiscal NaData()
        {
            this.Data = DateTime.Now;

            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorBruto,
                                Impostos, TodosItens, Observacoes);
        }
    }
}