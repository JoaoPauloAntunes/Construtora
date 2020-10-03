using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public abstract class PropriedadeModel
    {
        private string corPiso;
        private string corParede;
        private bool acessorioBanheiro;
        private bool acessorioCozinha;
        private string acabamentoParede;
        private string materialPorta;
        private Boolean isEncanamentoGas;

        public string CorPiso { get => corPiso; set => corPiso = value; }
        public string CorParede { get => corParede; set => corParede = value; }
        public bool AcessorioBanheiro { get => acessorioBanheiro; set => acessorioBanheiro = value; }
        public bool AcessorioCozinha { get => acessorioCozinha; set => acessorioCozinha = value; }
        public string AcabamentoParede { get => acabamentoParede; set => acabamentoParede = value; }
        public string MaterialPorta { get => materialPorta; set => materialPorta = value; }
        public bool IsEncanamentoGas { get => isEncanamentoGas; set => isEncanamentoGas = value; }
    }
}
