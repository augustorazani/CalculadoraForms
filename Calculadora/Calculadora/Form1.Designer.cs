namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnDois = new Button();
            btnCinco = new Button();
            btnQuatro = new Button();
            btnUm = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnTres = new Button();
            btnSeis = new Button();
            btnNove = new Button();
            btnZero = new Button();
            btnVirgula = new Button();
            btnIgual = new Button();
            btnDivisao = new Button();
            btnMultiplicacao = new Button();
            btnSubtracao = new Button();
            btnAdicao = new Button();
            btnLimpar = new Button();
            lblOperacao = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(28, 34);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(310, 27);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += textBox1_TextChanged;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(107, 281);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(73, 77);
            btnDois.TabIndex = 1;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(107, 198);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(73, 77);
            btnCinco.TabIndex = 2;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(28, 198);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(73, 77);
            btnQuatro.TabIndex = 3;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(28, 281);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(73, 77);
            btnUm.TabIndex = 4;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(28, 115);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(73, 77);
            btnSete.TabIndex = 5;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(107, 115);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(73, 77);
            btnOito.TabIndex = 6;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(186, 281);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(73, 77);
            btnTres.TabIndex = 7;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(186, 198);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(73, 77);
            btnSeis.TabIndex = 8;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(186, 115);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(73, 77);
            btnNove.TabIndex = 9;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(107, 364);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(73, 77);
            btnZero.TabIndex = 10;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(28, 364);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(73, 77);
            btnVirgula.TabIndex = 11;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(186, 364);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(73, 77);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(265, 115);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(73, 77);
            btnDivisao.TabIndex = 13;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Location = new Point(265, 198);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(73, 77);
            btnMultiplicacao.TabIndex = 14;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(265, 281);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(73, 77);
            btnSubtracao.TabIndex = 15;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.Location = new Point(265, 364);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(73, 77);
            btnAdicao.TabIndex = 16;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = true;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(265, 67);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(73, 42);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(28, 37);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 20);
            lblOperacao.TabIndex = 18;
            lblOperacao.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 466);
            Controls.Add(lblOperacao);
            Controls.Add(btnLimpar);
            Controls.Add(btnAdicao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Controls.Add(btnZero);
            Controls.Add(btnNove);
            Controls.Add(btnSeis);
            Controls.Add(btnTres);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnUm);
            Controls.Add(btnQuatro);
            Controls.Add(btnCinco);
            Controls.Add(btnDois);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnDois;
        private Button btnCinco;
        private Button btnQuatro;
        private Button btnUm;
        private Button btnSete;
        private Button btnOito;
        private Button btnTres;
        private Button btnSeis;
        private Button btnNove;
        private Button btnZero;
        private Button btnVirgula;
        private Button btnIgual;
        private Button btnDivisao;
        private Button btnMultiplicacao;
        private Button btnSubtracao;
        private Button btnAdicao;
        private Button btnLimpar;
        private Label lblOperacao;
    }
}
