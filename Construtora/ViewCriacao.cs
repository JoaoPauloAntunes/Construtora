using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
namespace Construtora
{
    public partial class ViewCriacao : Form
    {
        public ViewCriacao()
        {
            InitializeComponent();

            string[] cores = { "vermelho", "laranja", "amarelo", "verde", "ciano", "azul", "violeta" };
            comboBoxCorPiso.Items.AddRange(cores);
            comboBoxCorParede.Items.AddRange(cores);



            string[] marcasCano = { "Tigre", "Amanco", "Krona", "Nicoll | Provinil", "Cardinali", "Multilit", "Barbi", "Ferroplast", "Adequa" };
            comboBoxMarcaCano.Items.AddRange(marcasCano);



            string[] materiaisPorta = { "madeira", "aço", "alumínio", "PVC", "plástico", "vidro" };
            comboBoxMaterialPorta.Items.AddRange(materiaisPorta);



            string[] acabamentoParede = { "massa corrida ", "gesso" };
            comboBox6.Items.AddRange(acabamentoParede);
            comboBoxCorPiso.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBoxCorParede.SelectedIndex = 0;
            comboBoxMarcaCano.SelectedIndex = 0;
            comboBoxMaterialPorta.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ViewFinalizado vf = new ViewFinalizado();
            vf.Show();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
