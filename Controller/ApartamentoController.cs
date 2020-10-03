using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Controller
{
    public class ApartamentoController : IBuilder
    {
        ImovelModel imovelPadrao = new ImovelModel();
        ApartamentoModel apartamentoPadrao = new ApartamentoModel();

        public void ColocarPorta()
        {
            apartamentoPadrao.MaterialPorta = "madeira";
            imovelPadrao.Add(apartamentoPadrao.MaterialPorta);

        }

        public void ConstrucaoBanheiros()
        {
            apartamentoPadrao.CorPiso = "vermelho";
            apartamentoPadrao.CorParede = "vermelho";
            apartamentoPadrao.AcessorioBanheiro = false;
            imovelPadrao.Add(apartamentoPadrao.CorPiso);
            imovelPadrao.Add(apartamentoPadrao.CorParede);
            imovelPadrao.Add(apartamentoPadrao.AcessorioBanheiro ? "possui acessório no banheiro" : "não possui acessório no banheiro");
        }

        public void ConstrucaoCaixaDaAgua()
        {
            imovelPadrao.Add("não possui caixa d'água");
        }

        public void ConstrucaoEncanamento()
        {
            apartamentoPadrao.IsEncanamentoGas = false;
            imovelPadrao.Add(apartamentoPadrao.IsEncanamentoGas ? "possui encanamento com gás" : "não possui encanamento com gás");
            imovelPadrao.Add("não possui encamento");
        }

        public void FinalizacaoOperacoes()
        {
            imovelPadrao.Add("imovelPadrao finalizada");
        }

        public ImovelModel GetImovel()
        {
            return imovelPadrao;
        }

        public void InicializacaoOperacoes()
        {
            imovelPadrao.Add("Ajustando o terreno e construindo muros");
        }

        public void PintandoCasa()
        {
            apartamentoPadrao.CorParede = "vermelho";
            imovelPadrao.Add(apartamentoPadrao.CorParede);
        }

        public IBuilder ShallowCopy()
        {
            return (CasaController)this.MemberwiseClone();
        }
    }
}
