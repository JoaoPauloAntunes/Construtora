using System;
using System.Collections.Generic;
using System.Text;
using Model;
namespace Controller
{
    public class ChefeObraController
    {
        IBuilder builder;
        public void Construct(IBuilder builder)
        {
            this.builder = builder;
            builder.InicializacaoOperacoes();
            builder.ConstrucaoBanheiros();
            builder.ConstrucaoEncanamento();
            builder.ConstrucaoCaixaDaAgua();
            builder.ColocarPorta();
            builder.PintandoCasa();
            builder.FinalizacaoOperacoes();
        }
    }
}
