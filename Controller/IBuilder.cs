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
        void ConstrucaoComodos();
        void ConstrucaoBanheiros();
        void ConstrucaoEncanamento();
        void PintandoCasa();
        void FinalizacaoOperacoes();
        IBuilder ShallowCopy();
    }
}
