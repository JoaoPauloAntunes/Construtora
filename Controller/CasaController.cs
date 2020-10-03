using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Controller
{
    public class CasaController : IBuilder
    {
        ImovelModel imovelPadrao = new ImovelModel();
        CasaModel casaPadrao = new CasaModel();

        public void ColocarPorta()
        {
            casaPadrao.MaterialPorta = "madeira";
            imovelPadrao.Add(casaPadrao.MaterialPorta);

        }

        public void ConstrucaoCaixaDaAgua()
        {
            casaPadrao.IsCaixaDagua = false;
            imovelPadrao.Add(casaPadrao.IsCaixaDagua ? "possui caixa d'água" : "não possui caixa d'água");

        }

        public void ConstrucaoBanheiros()
        {
            casaPadrao.CorPiso = "vermelho";
            casaPadrao.CorParede = "vermelho";
            casaPadrao.AcessorioBanheiro = false;
            imovelPadrao.Add(casaPadrao.CorPiso);
            imovelPadrao.Add(casaPadrao.CorParede);
            imovelPadrao.Add(casaPadrao.AcessorioBanheiro ? "possui acessório no banheiro" : "não possui acessório no banheiro"); 
        }

        public void ConstrucaoEncanamento()
        {
            casaPadrao.MarcaCano = "Tigre";
            casaPadrao.IsEncanamentoGas = false;
            imovelPadrao.Add(casaPadrao.MarcaCano);
            imovelPadrao.Add(casaPadrao.IsEncanamentoGas ? "possui encanamento com gás" : "não possui encanamento com gás");
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
            casaPadrao.CorParede = "vermelho";
            imovelPadrao.Add(casaPadrao.CorParede);
        }

        public IBuilder ShallowCopy()
        {
            return (CasaController)this.MemberwiseClone();
        }
    }
}
