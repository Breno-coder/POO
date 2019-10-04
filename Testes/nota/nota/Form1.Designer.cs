namespace nota
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
            this.nota1 = new System.Windows.Forms.TextBox();
            this.nota4 = new System.Windows.Forms.TextBox();
            this.nota3 = new System.Windows.Forms.TextBox();
            this.nota2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaiornota = new System.Windows.Forms.TextBox();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.txtmenornota = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nota1
            // 
            this.nota1.Location = new System.Drawing.Point(124, 68);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(189, 20);
            this.nota1.TabIndex = 0;
            this.nota1.TextChanged += new System.EventHandler(this.nota1_TextChanged);
            this.nota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nota1_KeyPress);
            // 
            // nota4
            // 
            this.nota4.Location = new System.Drawing.Point(124, 181);
            this.nota4.Name = "nota4";
            this.nota4.Size = new System.Drawing.Size(189, 20);
            this.nota4.TabIndex = 1;
            this.nota4.TextChanged += new System.EventHandler(this.nota4_TextChanged);
            this.nota4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nota4_KeyPress);
            // 
            // nota3
            // 
            this.nota3.Location = new System.Drawing.Point(124, 144);
            this.nota3.Name = "nota3";
            this.nota3.Size = new System.Drawing.Size(189, 20);
            this.nota3.TabIndex = 2;
            this.nota3.TextChanged += new System.EventHandler(this.nota3_TextChanged);
            this.nota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nota3_KeyPress);
            // 
            // nota2
            // 
            this.nota2.Location = new System.Drawing.Point(124, 105);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(189, 20);
            this.nota2.TabIndex = 3;
            this.nota2.TextChanged += new System.EventHandler(this.nota2_TextChanged);
            this.nota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nota2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Maior Nota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Menor Nota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Media:";
            // 
            // txtmaiornota
            // 
            this.txtmaiornota.Enabled = false;
            this.txtmaiornota.Location = new System.Drawing.Point(263, 238);
            this.txtmaiornota.Name = "txtmaiornota";
            this.txtmaiornota.Size = new System.Drawing.Size(67, 20);
            this.txtmaiornota.TabIndex = 7;
            this.txtmaiornota.TextChanged += new System.EventHandler(this.txtmaiornota_TextChanged);
            // 
            // txtmedia
            // 
            this.txtmedia.Enabled = false;
            this.txtmedia.Location = new System.Drawing.Point(223, 305);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.Size = new System.Drawing.Size(67, 20);
            this.txtmedia.TabIndex = 8;
            this.txtmedia.TextChanged += new System.EventHandler(this.txtmedia_TextChanged);
            // 
            // txtmenornota
            // 
            this.txtmenornota.Enabled = false;
            this.txtmenornota.Location = new System.Drawing.Point(263, 269);
            this.txtmenornota.Name = "txtmenornota";
            this.txtmenornota.Size = new System.Drawing.Size(67, 20);
            this.txtmenornota.TabIndex = 9;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(492, 76);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(146, 105);
            this.btncalcular.TabIndex = 10;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpa
            // 
            this.btnlimpa.Location = new System.Drawing.Point(493, 241);
            this.btnlimpa.Name = "btnlimpa";
            this.btnlimpa.Size = new System.Drawing.Size(144, 94);
            this.btnlimpa.TabIndex = 11;
            this.btnlimpa.Text = "Limpar";
            this.btnlimpa.UseVisualStyleBackColor = true;
            this.btnlimpa.Click += new System.EventHandler(this.btnlimpa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nota 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nota 4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nota 3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nota 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnlimpa);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtmenornota);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.txtmaiornota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.nota3);
            this.Controls.Add(this.nota4);
            this.Controls.Add(this.nota1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nota1;
        private System.Windows.Forms.TextBox nota4;
        private System.Windows.Forms.TextBox nota3;
        private System.Windows.Forms.TextBox nota2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaiornota;
        private System.Windows.Forms.TextBox txtmedia;
        private System.Windows.Forms.TextBox txtmenornota;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

