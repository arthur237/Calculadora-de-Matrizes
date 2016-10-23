namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CriarMatrizA = new System.Windows.Forms.Button();
            this.LinhasMA = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Transposta = new System.Windows.Forms.Button();
            this.DeterminaB = new System.Windows.Forms.Button();
            this.Determina = new System.Windows.Forms.Button();
            this.InversaB = new System.Windows.Forms.Button();
            this.Inversa = new System.Windows.Forms.Button();
            this.InversaA = new System.Windows.Forms.Button();
            this.OpostaB = new System.Windows.Forms.Button();
            this.TranpostaB = new System.Windows.Forms.Button();
            this.Oposta = new System.Windows.Forms.Button();
            this.TranpostaA = new System.Windows.Forms.Button();
            this.DeterminaA = new System.Windows.Forms.Button();
            this.OpostaA = new System.Windows.Forms.Button();
            this.GrupoMatrizResultado = new System.Windows.Forms.GroupBox();
            this.GrupoMatrizB = new System.Windows.Forms.GroupBox();
            this.GrupoMatrizA = new System.Windows.Forms.GroupBox();
            this.linhaA = new System.Windows.Forms.TextBox();
            this.ColunaA = new System.Windows.Forms.TextBox();
            this.ColunasMA = new System.Windows.Forms.Label();
            this.LinhasMB = new System.Windows.Forms.Label();
            this.ColunasMB = new System.Windows.Forms.Label();
            this.LinhaB = new System.Windows.Forms.TextBox();
            this.ColunaB = new System.Windows.Forms.TextBox();
            this.CriarMatrizB = new System.Windows.Forms.Button();
            this.Multiplicar = new System.Windows.Forms.Button();
            this.BSubtracao = new System.Windows.Forms.Button();
            this.Soma = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CriarMatrizA
            // 
            this.CriarMatrizA.Location = new System.Drawing.Point(176, 16);
            this.CriarMatrizA.Name = "CriarMatrizA";
            this.CriarMatrizA.Size = new System.Drawing.Size(75, 23);
            this.CriarMatrizA.TabIndex = 0;
            this.CriarMatrizA.Text = "MatrizA";
            this.CriarMatrizA.UseVisualStyleBackColor = true;
            this.CriarMatrizA.Click += new System.EventHandler(this.CriarMatrizA_Click);
            // 
            // LinhasMA
            // 
            this.LinhasMA.AutoSize = true;
            this.LinhasMA.Location = new System.Drawing.Point(12, 12);
            this.LinhasMA.Name = "LinhasMA";
            this.LinhasMA.Size = new System.Drawing.Size(48, 13);
            this.LinhasMA.TabIndex = 1;
            this.LinhasMA.Text = "Linhas A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Transposta);
            this.groupBox1.Controls.Add(this.DeterminaB);
            this.groupBox1.Controls.Add(this.Determina);
            this.groupBox1.Controls.Add(this.InversaB);
            this.groupBox1.Controls.Add(this.Inversa);
            this.groupBox1.Controls.Add(this.InversaA);
            this.groupBox1.Controls.Add(this.OpostaB);
            this.groupBox1.Controls.Add(this.TranpostaB);
            this.groupBox1.Controls.Add(this.Oposta);
            this.groupBox1.Controls.Add(this.TranpostaA);
            this.groupBox1.Controls.Add(this.DeterminaA);
            this.groupBox1.Controls.Add(this.OpostaA);
            this.groupBox1.Controls.Add(this.GrupoMatrizResultado);
            this.groupBox1.Controls.Add(this.GrupoMatrizB);
            this.groupBox1.Controls.Add(this.GrupoMatrizA);
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 427);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Transposta
            // 
            this.Transposta.Location = new System.Drawing.Point(747, 366);
            this.Transposta.Name = "Transposta";
            this.Transposta.Size = new System.Drawing.Size(92, 23);
            this.Transposta.TabIndex = 24;
            this.Transposta.Text = "Transposta";
            this.Transposta.UseVisualStyleBackColor = true;
            this.Transposta.Click += new System.EventHandler(this.Transposta_Click);
            // 
            // DeterminaB
            // 
            this.DeterminaB.Location = new System.Drawing.Point(394, 337);
            this.DeterminaB.Name = "DeterminaB";
            this.DeterminaB.Size = new System.Drawing.Size(92, 23);
            this.DeterminaB.TabIndex = 23;
            this.DeterminaB.Text = "Determinante";
            this.DeterminaB.UseVisualStyleBackColor = true;
            this.DeterminaB.Click += new System.EventHandler(this.DeterminaB_Click);
            // 
            // Determina
            // 
            this.Determina.Location = new System.Drawing.Point(747, 337);
            this.Determina.Name = "Determina";
            this.Determina.Size = new System.Drawing.Size(92, 23);
            this.Determina.TabIndex = 22;
            this.Determina.Text = "Determinante";
            this.Determina.UseVisualStyleBackColor = true;
            this.Determina.Click += new System.EventHandler(this.Determina_Click);
            // 
            // InversaB
            // 
            this.InversaB.Location = new System.Drawing.Point(394, 395);
            this.InversaB.Name = "InversaB";
            this.InversaB.Size = new System.Drawing.Size(75, 23);
            this.InversaB.TabIndex = 21;
            this.InversaB.Text = "Inversa";
            this.InversaB.UseVisualStyleBackColor = true;
            this.InversaB.Click += new System.EventHandler(this.InversaB_Click);
            // 
            // Inversa
            // 
            this.Inversa.Location = new System.Drawing.Point(747, 395);
            this.Inversa.Name = "Inversa";
            this.Inversa.Size = new System.Drawing.Size(75, 23);
            this.Inversa.TabIndex = 20;
            this.Inversa.Text = "Inversa";
            this.Inversa.UseVisualStyleBackColor = true;
            this.Inversa.Click += new System.EventHandler(this.Inversa_Click);
            // 
            // InversaA
            // 
            this.InversaA.Location = new System.Drawing.Point(66, 395);
            this.InversaA.Name = "InversaA";
            this.InversaA.Size = new System.Drawing.Size(75, 23);
            this.InversaA.TabIndex = 19;
            this.InversaA.Text = "Inversa";
            this.InversaA.UseVisualStyleBackColor = true;
            this.InversaA.Click += new System.EventHandler(this.InversaA_Click);
            // 
            // OpostaB
            // 
            this.OpostaB.Location = new System.Drawing.Point(394, 308);
            this.OpostaB.Name = "OpostaB";
            this.OpostaB.Size = new System.Drawing.Size(75, 23);
            this.OpostaB.TabIndex = 16;
            this.OpostaB.Text = "Oposta";
            this.OpostaB.UseVisualStyleBackColor = true;
            this.OpostaB.Click += new System.EventHandler(this.OpostaB_Click);
            // 
            // TranpostaB
            // 
            this.TranpostaB.Location = new System.Drawing.Point(394, 366);
            this.TranpostaB.Name = "TranpostaB";
            this.TranpostaB.Size = new System.Drawing.Size(75, 23);
            this.TranpostaB.TabIndex = 14;
            this.TranpostaB.Text = "Transposta";
            this.TranpostaB.UseVisualStyleBackColor = true;
            this.TranpostaB.Click += new System.EventHandler(this.TranpostaB_Click);
            // 
            // Oposta
            // 
            this.Oposta.Location = new System.Drawing.Point(747, 308);
            this.Oposta.Name = "Oposta";
            this.Oposta.Size = new System.Drawing.Size(75, 23);
            this.Oposta.TabIndex = 18;
            this.Oposta.Text = "Oposta";
            this.Oposta.UseVisualStyleBackColor = true;
            this.Oposta.Click += new System.EventHandler(this.Oposta_Click);
            // 
            // TranpostaA
            // 
            this.TranpostaA.Location = new System.Drawing.Point(66, 366);
            this.TranpostaA.Name = "TranpostaA";
            this.TranpostaA.Size = new System.Drawing.Size(75, 23);
            this.TranpostaA.TabIndex = 11;
            this.TranpostaA.Text = "Transposta";
            this.TranpostaA.UseVisualStyleBackColor = true;
            this.TranpostaA.Click += new System.EventHandler(this.TranpostaA_Click);
            // 
            // DeterminaA
            // 
            this.DeterminaA.Location = new System.Drawing.Point(66, 337);
            this.DeterminaA.Name = "DeterminaA";
            this.DeterminaA.Size = new System.Drawing.Size(92, 23);
            this.DeterminaA.TabIndex = 12;
            this.DeterminaA.Text = "Determinante";
            this.DeterminaA.UseVisualStyleBackColor = true;
            this.DeterminaA.Click += new System.EventHandler(this.DeterminaA_Click);
            // 
            // OpostaA
            // 
            this.OpostaA.Location = new System.Drawing.Point(66, 308);
            this.OpostaA.Name = "OpostaA";
            this.OpostaA.Size = new System.Drawing.Size(75, 23);
            this.OpostaA.TabIndex = 13;
            this.OpostaA.Text = "Oposta";
            this.OpostaA.UseVisualStyleBackColor = true;
            this.OpostaA.Click += new System.EventHandler(this.OpostaA_Click);
            // 
            // GrupoMatrizResultado
            // 
            this.GrupoMatrizResultado.Location = new System.Drawing.Point(637, 16);
            this.GrupoMatrizResultado.Name = "GrupoMatrizResultado";
            this.GrupoMatrizResultado.Size = new System.Drawing.Size(287, 265);
            this.GrupoMatrizResultado.TabIndex = 1;
            this.GrupoMatrizResultado.TabStop = false;
            this.GrupoMatrizResultado.Text = "Matriz R";
            // 
            // GrupoMatrizB
            // 
            this.GrupoMatrizB.Location = new System.Drawing.Point(299, 19);
            this.GrupoMatrizB.Name = "GrupoMatrizB";
            this.GrupoMatrizB.Size = new System.Drawing.Size(295, 262);
            this.GrupoMatrizB.TabIndex = 1;
            this.GrupoMatrizB.TabStop = false;
            this.GrupoMatrizB.Text = "Matriz B";
            // 
            // GrupoMatrizA
            // 
            this.GrupoMatrizA.Location = new System.Drawing.Point(3, 16);
            this.GrupoMatrizA.Name = "GrupoMatrizA";
            this.GrupoMatrizA.Size = new System.Drawing.Size(276, 265);
            this.GrupoMatrizA.TabIndex = 0;
            this.GrupoMatrizA.TabStop = false;
            this.GrupoMatrizA.Text = "Matriz A";
            // 
            // linhaA
            // 
            this.linhaA.Location = new System.Drawing.Point(70, 9);
            this.linhaA.Name = "linhaA";
            this.linhaA.Size = new System.Drawing.Size(100, 20);
            this.linhaA.TabIndex = 3;
            this.linhaA.TextChanged += new System.EventHandler(this.linhaA_TextChanged);
            this.linhaA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.linhaA_KeyPress);
            // 
            // ColunaA
            // 
            this.ColunaA.Location = new System.Drawing.Point(70, 35);
            this.ColunaA.Name = "ColunaA";
            this.ColunaA.Size = new System.Drawing.Size(100, 20);
            this.ColunaA.TabIndex = 4;
            this.ColunaA.TextChanged += new System.EventHandler(this.ColunaA_TextChanged);
            this.ColunaA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ColunaA_KeyPress);
            // 
            // ColunasMA
            // 
            this.ColunasMA.AutoSize = true;
            this.ColunasMA.Location = new System.Drawing.Point(9, 38);
            this.ColunasMA.Name = "ColunasMA";
            this.ColunasMA.Size = new System.Drawing.Size(55, 13);
            this.ColunasMA.TabIndex = 5;
            this.ColunasMA.Text = "Colunas A";
            // 
            // LinhasMB
            // 
            this.LinhasMB.AutoSize = true;
            this.LinhasMB.Location = new System.Drawing.Point(285, 16);
            this.LinhasMB.Name = "LinhasMB";
            this.LinhasMB.Size = new System.Drawing.Size(48, 13);
            this.LinhasMB.TabIndex = 6;
            this.LinhasMB.Text = "Linhas B";
            // 
            // ColunasMB
            // 
            this.ColunasMB.AutoSize = true;
            this.ColunasMB.Location = new System.Drawing.Point(285, 42);
            this.ColunasMB.Name = "ColunasMB";
            this.ColunasMB.Size = new System.Drawing.Size(55, 13);
            this.ColunasMB.TabIndex = 7;
            this.ColunasMB.Text = "Colunas B";
            // 
            // LinhaB
            // 
            this.LinhaB.Location = new System.Drawing.Point(350, 12);
            this.LinhaB.Name = "LinhaB";
            this.LinhaB.Size = new System.Drawing.Size(100, 20);
            this.LinhaB.TabIndex = 8;
            this.LinhaB.TextChanged += new System.EventHandler(this.LinhaB_TextChanged);
            this.LinhaB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LinhaB_KeyPress);
            // 
            // ColunaB
            // 
            this.ColunaB.Location = new System.Drawing.Point(350, 39);
            this.ColunaB.Name = "ColunaB";
            this.ColunaB.Size = new System.Drawing.Size(100, 20);
            this.ColunaB.TabIndex = 9;
            this.ColunaB.TextChanged += new System.EventHandler(this.ColunaB_TextChanged);
            this.ColunaB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ColunaB_KeyPress);
            // 
            // CriarMatrizB
            // 
            this.CriarMatrizB.Location = new System.Drawing.Point(456, 16);
            this.CriarMatrizB.Name = "CriarMatrizB";
            this.CriarMatrizB.Size = new System.Drawing.Size(75, 23);
            this.CriarMatrizB.TabIndex = 10;
            this.CriarMatrizB.Text = "MatrizB";
            this.CriarMatrizB.UseVisualStyleBackColor = true;
            this.CriarMatrizB.Click += new System.EventHandler(this.CriarMatrizB_Click);
            // 
            // Multiplicar
            // 
            this.Multiplicar.Location = new System.Drawing.Point(269, 82);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(75, 23);
            this.Multiplicar.TabIndex = 19;
            this.Multiplicar.Text = "Multiplicar";
            this.Multiplicar.UseVisualStyleBackColor = true;
            this.Multiplicar.Click += new System.EventHandler(this.Multiplicar_Click);
            // 
            // BSubtracao
            // 
            this.BSubtracao.Location = new System.Drawing.Point(188, 82);
            this.BSubtracao.Name = "BSubtracao";
            this.BSubtracao.Size = new System.Drawing.Size(75, 23);
            this.BSubtracao.TabIndex = 22;
            this.BSubtracao.Text = "Subtrair";
            this.BSubtracao.UseVisualStyleBackColor = true;
            this.BSubtracao.Click += new System.EventHandler(this.BSubtracao_Click);
            // 
            // Soma
            // 
            this.Soma.Location = new System.Drawing.Point(107, 82);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(75, 23);
            this.Soma.TabIndex = 23;
            this.Soma.Text = "Somar";
            this.Soma.UseVisualStyleBackColor = true;
            this.Soma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 583);
            this.Controls.Add(this.BSubtracao);
            this.Controls.Add(this.Soma);
            this.Controls.Add(this.Multiplicar);
            this.Controls.Add(this.CriarMatrizB);
            this.Controls.Add(this.ColunaB);
            this.Controls.Add(this.LinhaB);
            this.Controls.Add(this.ColunasMB);
            this.Controls.Add(this.LinhasMB);
            this.Controls.Add(this.ColunasMA);
            this.Controls.Add(this.ColunaA);
            this.Controls.Add(this.linhaA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LinhasMA);
            this.Controls.Add(this.CriarMatrizA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CriarMatrizA;
        private System.Windows.Forms.Label LinhasMA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox linhaA;
        private System.Windows.Forms.TextBox ColunaA;
        private System.Windows.Forms.Label ColunasMA;
        private System.Windows.Forms.Button Multiplicar;
        private System.Windows.Forms.Button Oposta;
        private System.Windows.Forms.Button OpostaB;
        private System.Windows.Forms.Button TranpostaB;
        private System.Windows.Forms.Button TranpostaA;
        private System.Windows.Forms.Button DeterminaA;
        private System.Windows.Forms.Button OpostaA;
        private System.Windows.Forms.GroupBox GrupoMatrizResultado;
        private System.Windows.Forms.GroupBox GrupoMatrizB;
        private System.Windows.Forms.GroupBox GrupoMatrizA;
        private System.Windows.Forms.Label LinhasMB;
        private System.Windows.Forms.Label ColunasMB;
        private System.Windows.Forms.TextBox LinhaB;
        private System.Windows.Forms.TextBox ColunaB;
        private System.Windows.Forms.Button CriarMatrizB;
        private System.Windows.Forms.Button BSubtracao;
        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button DeterminaB;
        private System.Windows.Forms.Button Determina;
        private System.Windows.Forms.Button InversaB;
        private System.Windows.Forms.Button Inversa;
        private System.Windows.Forms.Button InversaA;
        private System.Windows.Forms.Button Transposta;
    }
}

