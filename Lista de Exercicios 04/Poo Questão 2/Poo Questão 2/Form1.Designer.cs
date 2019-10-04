namespace Poo_Questão_2
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
            this.btn_subtracao = new System.Windows.Forms.Button();
            this.btn_multiplicacao = new System.Windows.Forms.Button();
            this.btn_adicao = new System.Windows.Forms.Button();
            this.btn_divisao = new System.Windows.Forms.Button();
            this.txt_Primeironumero = new System.Windows.Forms.TextBox();
            this.btn_potencia = new System.Windows.Forms.Button();
            this.btn_raiz = new System.Windows.Forms.Button();
            this.lbl_operador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.txt_Segundonumero = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_subtracao
            // 
            this.btn_subtracao.Location = new System.Drawing.Point(76, 101);
            this.btn_subtracao.Name = "btn_subtracao";
            this.btn_subtracao.Size = new System.Drawing.Size(46, 36);
            this.btn_subtracao.TabIndex = 0;
            this.btn_subtracao.Text = "-";
            this.btn_subtracao.UseVisualStyleBackColor = true;
            this.btn_subtracao.Click += new System.EventHandler(this.btn_subtracao_Click);
            // 
            // btn_multiplicacao
            // 
            this.btn_multiplicacao.Location = new System.Drawing.Point(24, 159);
            this.btn_multiplicacao.Name = "btn_multiplicacao";
            this.btn_multiplicacao.Size = new System.Drawing.Size(46, 36);
            this.btn_multiplicacao.TabIndex = 1;
            this.btn_multiplicacao.Text = "x";
            this.btn_multiplicacao.UseVisualStyleBackColor = true;
            this.btn_multiplicacao.Click += new System.EventHandler(this.btn_multiplicacao_Click);
            // 
            // btn_adicao
            // 
            this.btn_adicao.Location = new System.Drawing.Point(24, 101);
            this.btn_adicao.Name = "btn_adicao";
            this.btn_adicao.Size = new System.Drawing.Size(46, 36);
            this.btn_adicao.TabIndex = 2;
            this.btn_adicao.Text = "+";
            this.btn_adicao.UseVisualStyleBackColor = true;
            this.btn_adicao.Click += new System.EventHandler(this.btn_adicao_Click);
            // 
            // btn_divisao
            // 
            this.btn_divisao.Location = new System.Drawing.Point(76, 159);
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Size = new System.Drawing.Size(46, 36);
            this.btn_divisao.TabIndex = 3;
            this.btn_divisao.Text = "/";
            this.btn_divisao.UseVisualStyleBackColor = true;
            this.btn_divisao.Click += new System.EventHandler(this.btn_divisao_Click);
            // 
            // txt_Primeironumero
            // 
            this.txt_Primeironumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Primeironumero.Location = new System.Drawing.Point(12, 35);
            this.txt_Primeironumero.Name = "txt_Primeironumero";
            this.txt_Primeironumero.Size = new System.Drawing.Size(130, 41);
            this.txt_Primeironumero.TabIndex = 4;
            this.txt_Primeironumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Primeironumero.TextChanged += new System.EventHandler(this.txt_Primeironumero_TextChanged);
            this.txt_Primeironumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Primeironumero_KeyPress);
            // 
            // btn_potencia
            // 
            this.btn_potencia.Location = new System.Drawing.Point(226, 159);
            this.btn_potencia.Name = "btn_potencia";
            this.btn_potencia.Size = new System.Drawing.Size(46, 36);
            this.btn_potencia.TabIndex = 6;
            this.btn_potencia.Text = "^";
            this.btn_potencia.UseVisualStyleBackColor = true;
            this.btn_potencia.Click += new System.EventHandler(this.btn_potencia_Click);
            // 
            // btn_raiz
            // 
            this.btn_raiz.Location = new System.Drawing.Point(226, 101);
            this.btn_raiz.Name = "btn_raiz";
            this.btn_raiz.Size = new System.Drawing.Size(46, 36);
            this.btn_raiz.TabIndex = 7;
            this.btn_raiz.Text = "√";
            this.btn_raiz.UseVisualStyleBackColor = true;
            this.btn_raiz.Click += new System.EventHandler(this.btn_raiz_Click);
            // 
            // lbl_operador
            // 
            this.lbl_operador.AutoSize = true;
            this.lbl_operador.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operador.Location = new System.Drawing.Point(148, 40);
            this.lbl_operador.Name = "lbl_operador";
            this.lbl_operador.Size = new System.Drawing.Size(0, 36);
            this.lbl_operador.TabIndex = 8;
            this.lbl_operador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(383, 38);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 36);
            this.lbl_resultado.TabIndex = 10;
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Segundonumero
            // 
            this.txt_Segundonumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Segundonumero.Location = new System.Drawing.Point(194, 35);
            this.txt_Segundonumero.Name = "txt_Segundonumero";
            this.txt_Segundonumero.Size = new System.Drawing.Size(130, 41);
            this.txt_Segundonumero.TabIndex = 11;
            this.txt_Segundonumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Segundonumero.TextChanged += new System.EventHandler(this.txt_Segundonumero_TextChanged);
            this.txt_Segundonumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Segundonumero_KeyPress);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(370, 185);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 39);
            this.btnreset.TabIndex = 12;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Raiz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 225);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txt_Segundonumero);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_operador);
            this.Controls.Add(this.btn_raiz);
            this.Controls.Add(this.btn_potencia);
            this.Controls.Add(this.txt_Primeironumero);
            this.Controls.Add(this.btn_divisao);
            this.Controls.Add(this.btn_adicao);
            this.Controls.Add(this.btn_multiplicacao);
            this.Controls.Add(this.btn_subtracao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_subtracao;
        private System.Windows.Forms.Button btn_multiplicacao;
        private System.Windows.Forms.Button btn_adicao;
        private System.Windows.Forms.Button btn_divisao;
        private System.Windows.Forms.TextBox txt_Primeironumero;
        private System.Windows.Forms.Button btn_potencia;
        private System.Windows.Forms.Button btn_raiz;
        private System.Windows.Forms.Label lbl_operador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.TextBox txt_Segundonumero;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label2;
    }
}

