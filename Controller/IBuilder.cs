using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    public interface IBuilder
    {
        ImovelModel GetImovel();
        void InicializacaoOperacoes();
        void ConstrucaoBanheiros();
        void ConstrucaoEncanamento();
        void ConstrucaoCaixaDaAgua();
        void ColocarPorta();
        void PintandoCasa();
        void FinalizacaoOperacoes();
        IBuilder ShallowCopy();
    }
}
