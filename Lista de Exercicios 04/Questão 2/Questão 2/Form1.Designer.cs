namespace Questão_2
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
            this.lblequak = new System.Windows.Forms.Label();
            this.txtsegundo = new System.Windows.Forms.TextBox();
            this.txtprimeiro = new System.Windows.Forms.TextBox();
            this.btnmultiplica = new System.Windows.Forms.Button();
            this.btnsubtrai = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnsoma = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblequak
            // 
            this.lblequak.AutoSize = true;
            this.lblequak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblequak.Location = new System.Drawing.Point(353, 98);
            this.lblequak.Name = "lblequak";
            this.lblequak.Size = new System.Drawing.Size(30, 31);
            this.lblequak.TabIndex = 0;
            this.lblequak.Text = "=";
            // 
            // txtsegundo
            // 
            this.txtsegundo.Location = new System.Drawing.Point(101, 125);
            this.txtsegundo.Name = "txtsegundo";
            this.txtsegundo.Size = new System.Drawing.Size(107, 20);
            this.txtsegundo.TabIndex = 1;
            // 
            // txtprimeiro
            // 
            this.txtprimeiro.Location = new System.Drawing.Point(101, 72);
            this.txtprimeiro.Name = "txtprimeiro";
            this.txtprimeiro.Size = new System.Drawing.Size(107, 20);
            this.txtprimeiro.TabIndex = 2;
            // 
            // btnmultiplica
            // 
            this.btnmultiplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplica.Location = new System.Drawing.Point(257, 138);
            this.btnmultiplica.Name = "btnmultiplica";
            this.btnmultiplica.Size = new System.Drawing.Size(55, 34);
            this.btnmultiplica.TabIndex = 3;
            this.btnmultiplica.Text = "x";
            this.btnmultiplica.UseVisualStyleBackColor = true;
            // 
            // btnsubtrai
            // 
            this.btnsubtrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubtrai.Location = new System.Drawing.Point(257, 98);
            this.btnsubtrai.Name = "btnsubtrai";
            this.btnsubtrai.Size = new System.Drawing.Size(55, 34);
            this.btnsubtrai.TabIndex = 4;
            this.btnsubtrai.Text = "-";
            this.btnsubtrai.UseVisualStyleBackColor = true;
            // 
            // btndivide
            // 
            this.btndivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivide.Location = new System.Drawing.Point(257, 178);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(55, 34);
            this.btndivide.TabIndex = 5;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            // 
            // btnsoma
            // 
            this.btnsoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsoma.Location = new System.Drawing.Point(257, 58);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(55, 34);
            this.btnsoma.TabIndex = 6;
            this.btnsoma.Text = "+";
            this.btnsoma.UseVisualStyleBackColor = true;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(420, 101);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 31);
            this.lblresult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 262);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnsubtrai);
            this.Controls.Add(this.btnmultiplica);
            this.Controls.Add(this.txtprimeiro);
            this.Controls.Add(this.txtsegundo);
            this.Controls.Add(this.lblequak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblequak;
        private System.Windows.Forms.TextBox txtsegundo;
        private System.Windows.Forms.TextBox txtprimeiro;
        private System.Windows.Forms.Button btnmultiplica;
        private System.Windows.Forms.Button btnsubtrai;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Label lblresult;
    }
}

