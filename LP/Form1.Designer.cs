namespace LP
{
    partial class Form1
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
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorAPagar = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCaulcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Categorias = new System.Windows.Forms.GroupBox();
            this.Wii = new System.Windows.Forms.RadioButton();
            this.PlayStaion = new System.Windows.Forms.RadioButton();
            this.xBox = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NomeJogo = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Categorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(107, 301);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 22);
            this.txtPreco.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(432, 301);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 22);
            this.txtQuantidade.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Preço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade";
            // 
            // txtValorAPagar
            // 
            this.txtValorAPagar.Location = new System.Drawing.Point(627, 346);
            this.txtValorAPagar.Name = "txtValorAPagar";
            this.txtValorAPagar.ReadOnly = true;
            this.txtValorAPagar.Size = new System.Drawing.Size(121, 22);
            this.txtValorAPagar.TabIndex = 8;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIniciar.ForeColor = System.Drawing.Color.Black;
            this.btnIniciar.Location = new System.Drawing.Point(81, 399);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(126, 30);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLimpar.Location = new System.Drawing.Point(321, 402);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(173, 27);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCaulcular
            // 
            this.btnCaulcular.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCaulcular.Location = new System.Drawing.Point(599, 399);
            this.btnCaulcular.Name = "btnCaulcular";
            this.btnCaulcular.Size = new System.Drawing.Size(173, 30);
            this.btnCaulcular.TabIndex = 11;
            this.btnCaulcular.Text = "Valor a Pagar";
            this.btnCaulcular.UseVisualStyleBackColor = false;
            this.btnCaulcular.Click += new System.EventHandler(this.btnCaulcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(514, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valor a Pagar";
            // 
            // Categorias
            // 
            this.Categorias.Controls.Add(this.Wii);
            this.Categorias.Controls.Add(this.PlayStaion);
            this.Categorias.Controls.Add(this.xBox);
            this.Categorias.Location = new System.Drawing.Point(49, 24);
            this.Categorias.Name = "Categorias";
            this.Categorias.Size = new System.Drawing.Size(699, 100);
            this.Categorias.TabIndex = 13;
            this.Categorias.TabStop = false;
            this.Categorias.Text = "Categoria";
            this.Categorias.Enter += new System.EventHandler(this.Categorias_Enter);
            // 
            // Wii
            // 
            this.Wii.AutoSize = true;
            this.Wii.Location = new System.Drawing.Point(495, 45);
            this.Wii.Name = "Wii";
            this.Wii.Size = new System.Drawing.Size(47, 20);
            this.Wii.TabIndex = 2;
            this.Wii.TabStop = true;
            this.Wii.Text = "Wii";
            this.Wii.UseVisualStyleBackColor = true;
            this.Wii.CheckedChanged += new System.EventHandler(this.Wii_CheckedChanged);
            // 
            // PlayStaion
            // 
            this.PlayStaion.AutoSize = true;
            this.PlayStaion.Location = new System.Drawing.Point(272, 45);
            this.PlayStaion.Name = "PlayStaion";
            this.PlayStaion.Size = new System.Drawing.Size(96, 20);
            this.PlayStaion.TabIndex = 1;
            this.PlayStaion.TabStop = true;
            this.PlayStaion.Text = "PlayStation";
            this.PlayStaion.UseVisualStyleBackColor = true;
            this.PlayStaion.CheckedChanged += new System.EventHandler(this.PlayStaion_CheckedChanged);
            // 
            // xBox
            // 
            this.xBox.AutoSize = true;
            this.xBox.Location = new System.Drawing.Point(55, 45);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(57, 20);
            this.xBox.TabIndex = 0;
            this.xBox.TabStop = true;
            this.xBox.Text = "xBox";
            this.xBox.UseVisualStyleBackColor = true;
            this.xBox.CheckedChanged += new System.EventHandler(this.xBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Categoria Selecionada";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 22);
            this.textBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nome  Jogo";
            // 
            // NomeJogo
            // 
            this.NomeJogo.Location = new System.Drawing.Point(212, 233);
            this.NomeJogo.Name = "NomeJogo";
            this.NomeJogo.Size = new System.Drawing.Size(293, 22);
            this.NomeJogo.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(627, 307);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 20);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Desconto 10%";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.NomeJogo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Categorias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCaulcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtValorAPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtPreco);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Avaliação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Categorias.ResumeLayout(false);
            this.Categorias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorAPagar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCaulcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Categorias;
        private System.Windows.Forms.RadioButton Wii;
        private System.Windows.Forms.RadioButton PlayStaion;
        private System.Windows.Forms.RadioButton xBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NomeJogo;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

