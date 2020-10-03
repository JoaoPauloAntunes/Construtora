namespace Construtora
{
    partial class ViewCriacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxMaterialPorta = new System.Windows.Forms.ComboBox();
            this.comboBoxMarcaCano = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBoxCorParede = new System.Windows.Forms.ComboBox();
            this.comboBoxCorPiso = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 32);
            this.button1.TabIndex = 49;
            this.button1.Text = "Terminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBoxMaterialPorta
            // 
            this.comboBoxMaterialPorta.FormattingEnabled = true;
            this.comboBoxMaterialPorta.Items.AddRange(new object[] {
            "casa",
            "apartamento"});
            this.comboBoxMaterialPorta.Location = new System.Drawing.Point(15, 303);
            this.comboBoxMaterialPorta.Name = "comboBoxMaterialPorta";
            this.comboBoxMaterialPorta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterialPorta.TabIndex = 42;
            this.comboBoxMaterialPorta.SelectedIndexChanged += new System.EventHandler(this.ComboBox8_SelectedIndexChanged);
            // 
            // comboBoxMarcaCano
            // 
            this.comboBoxMarcaCano.FormattingEnabled = true;
            this.comboBoxMarcaCano.Location = new System.Drawing.Point(15, 252);
            this.comboBoxMarcaCano.Name = "comboBoxMarcaCano";
            this.comboBoxMarcaCano.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarcaCano.TabIndex = 41;
            this.comboBoxMarcaCano.SelectedIndexChanged += new System.EventHandler(this.ComboBox7_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(15, 197);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 40;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.ComboBox6_SelectedIndexChanged);
            // 
            // comboBoxCorParede
            // 
            this.comboBoxCorParede.FormattingEnabled = true;
            this.comboBoxCorParede.Items.AddRange(new object[] {
            "casa",
            "apartamento"});
            this.comboBoxCorParede.Location = new System.Drawing.Point(15, 139);
            this.comboBoxCorParede.Name = "comboBoxCorParede";
            this.comboBoxCorParede.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCorParede.TabIndex = 37;
            this.comboBoxCorParede.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // comboBoxCorPiso
            // 
            this.comboBoxCorPiso.FormattingEnabled = true;
            this.comboBoxCorPiso.Location = new System.Drawing.Point(15, 87);
            this.comboBoxCorPiso.Name = "comboBoxCorPiso";
            this.comboBoxCorPiso.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCorPiso.TabIndex = 36;
            this.comboBoxCorPiso.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 35;
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Material porta";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Marca cano";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Acabamento parede";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cor parede";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cor piso";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tipo imovel";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "casa",
            "apartamento"});
            this.comboBox1.Location = new System.Drawing.Point(15, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(215, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Caixa d\'água?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(215, 78);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(142, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Encanamento para gas?";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(215, 32);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(142, 17);
            this.checkBox3.TabIndex = 50;
            this.checkBox3.Text = "Acessorios no banheiro?";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(215, 55);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(142, 17);
            this.checkBox4.TabIndex = 51;
            this.checkBox4.Text = "Acessorios na cozinha?";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // ViewCriacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 347);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxMaterialPorta);
            this.Controls.Add(this.comboBoxMarcaCano);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBoxCorParede);
            this.Controls.Add(this.comboBoxCorPiso);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "ViewCriacao";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ViewCriacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxMaterialPorta;
        private System.Windows.Forms.ComboBox comboBoxMarcaCano;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBoxCorParede;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxCorPiso;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}

