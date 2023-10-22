namespace programacao.visual.aula.login.calculadora
{
    partial class FormPrincipal
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
            this.calculateSection = new System.Windows.Forms.GroupBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.nmSegundoValor = new System.Windows.Forms.NumericUpDown();
            this.nmPrimeiroValor = new System.Windows.Forms.NumericUpDown();
            this.btnSoma = new System.Windows.Forms.Button();
            this.secondNumberLabel = new System.Windows.Forms.Label();
            this.firstNumberLabel = new System.Windows.Forms.Label();
            this.sair = new System.Windows.Forms.Button();
            this.calculateSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSegundoValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrimeiroValor)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateSection
            // 
            this.calculateSection.Controls.Add(this.btnDividir);
            this.calculateSection.Controls.Add(this.btnMultiplicar);
            this.calculateSection.Controls.Add(this.btnSubtrair);
            this.calculateSection.Controls.Add(this.lblResultado);
            this.calculateSection.Controls.Add(this.txtResultado);
            this.calculateSection.Controls.Add(this.nmSegundoValor);
            this.calculateSection.Controls.Add(this.nmPrimeiroValor);
            this.calculateSection.Controls.Add(this.btnSoma);
            this.calculateSection.Controls.Add(this.secondNumberLabel);
            this.calculateSection.Controls.Add(this.firstNumberLabel);
            this.calculateSection.Location = new System.Drawing.Point(12, 12);
            this.calculateSection.Name = "calculateSection";
            this.calculateSection.Size = new System.Drawing.Size(380, 222);
            this.calculateSection.TabIndex = 9;
            this.calculateSection.TabStop = false;
            this.calculateSection.Text = "Calculadora";
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.Moccasin;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(261, 159);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(102, 39);
            this.btnDividir.TabIndex = 12;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.SystemColors.Info;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(261, 69);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(102, 39);
            this.btnMultiplicar.TabIndex = 11;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(261, 24);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(102, 39);
            this.btnSubtrair.TabIndex = 10;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(30, 103);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(61, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(33, 128);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(213, 20);
            this.txtResultado.TabIndex = 9;
            // 
            // nmSegundoValor
            // 
            this.nmSegundoValor.Location = new System.Drawing.Point(126, 71);
            this.nmSegundoValor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmSegundoValor.Name = "nmSegundoValor";
            this.nmSegundoValor.Size = new System.Drawing.Size(120, 20);
            this.nmSegundoValor.TabIndex = 8;
            // 
            // nmPrimeiroValor
            // 
            this.nmPrimeiroValor.Location = new System.Drawing.Point(126, 34);
            this.nmPrimeiroValor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmPrimeiroValor.Name = "nmPrimeiroValor";
            this.nmPrimeiroValor.Size = new System.Drawing.Size(120, 20);
            this.nmPrimeiroValor.TabIndex = 7;
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.Maroon;
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(261, 114);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(102, 39);
            this.btnSoma.TabIndex = 6;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // secondNumberLabel
            // 
            this.secondNumberLabel.AutoSize = true;
            this.secondNumberLabel.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumberLabel.Location = new System.Drawing.Point(30, 78);
            this.secondNumberLabel.Name = "secondNumberLabel";
            this.secondNumberLabel.Size = new System.Drawing.Size(93, 12);
            this.secondNumberLabel.TabIndex = 5;
            this.secondNumberLabel.Text = "Segundo Número";
            // 
            // firstNumberLabel
            // 
            this.firstNumberLabel.AutoSize = true;
            this.firstNumberLabel.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumberLabel.Location = new System.Drawing.Point(30, 41);
            this.firstNumberLabel.Name = "firstNumberLabel";
            this.firstNumberLabel.Size = new System.Drawing.Size(93, 12);
            this.firstNumberLabel.TabIndex = 3;
            this.firstNumberLabel.Text = "Primeiro número";
            // 
            // sair
            // 
            this.sair.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Location = new System.Drawing.Point(246, 240);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(146, 39);
            this.sair.TabIndex = 13;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 304);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.calculateSection);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.calculateSection.ResumeLayout(false);
            this.calculateSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSegundoValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrimeiroValor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox calculateSection;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.NumericUpDown nmSegundoValor;
        private System.Windows.Forms.NumericUpDown nmPrimeiroValor;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Label secondNumberLabel;
        private System.Windows.Forms.Label firstNumberLabel;
        private System.Windows.Forms.Button sair;
    }
}

