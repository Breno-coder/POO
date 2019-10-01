namespace Questão_1
{
    partial class Resultado
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
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblClassificacaodoIMC = new System.Windows.Forms.Label();
            this.lblClassificacaodopercentualdegordura = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(229, 97);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(67, 31);
            this.lblIMC.TabIndex = 0;
            this.lblIMC.Text = "IMC";
            // 
            // lblClassificacaodoIMC
            // 
            this.lblClassificacaodoIMC.AutoSize = true;
            this.lblClassificacaodoIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassificacaodoIMC.Location = new System.Drawing.Point(125, 155);
            this.lblClassificacaodoIMC.Name = "lblClassificacaodoIMC";
            this.lblClassificacaodoIMC.Size = new System.Drawing.Size(290, 31);
            this.lblClassificacaodoIMC.TabIndex = 2;
            this.lblClassificacaodoIMC.Text = "Classificação do IMC";
            // 
            // lblClassificacaodopercentualdegordura
            // 
            this.lblClassificacaodopercentualdegordura.AutoSize = true;
            this.lblClassificacaodopercentualdegordura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassificacaodopercentualdegordura.Location = new System.Drawing.Point(12, 215);
            this.lblClassificacaodopercentualdegordura.Name = "lblClassificacaodopercentualdegordura";
            this.lblClassificacaodopercentualdegordura.Size = new System.Drawing.Size(531, 31);
            this.lblClassificacaodopercentualdegordura.TabIndex = 3;
            this.lblClassificacaodopercentualdegordura.Text = "Classificação do Percentual de Gordura";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(213, 32);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(82, 33);
            this.lblnome.TabIndex = 4;
            this.lblnome.Text = "label";
            this.lblnome.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 283);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblClassificacaodopercentualdegordura);
            this.Controls.Add(this.lblClassificacaodoIMC);
            this.Controls.Add(this.lblIMC);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.Resultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblClassificacaodoIMC;
        private System.Windows.Forms.Label lblClassificacaodopercentualdegordura;
        private System.Windows.Forms.Label lblnome;
    }
}