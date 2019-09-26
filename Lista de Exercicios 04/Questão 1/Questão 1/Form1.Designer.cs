namespace Questão_1
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
            this.escolhasexo = new System.Windows.Forms.ComboBox();
            this.txbsobrenome = new System.Windows.Forms.TextBox();
            this.txbidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // escolhasexo
            // 
            this.escolhasexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolhasexo.FormattingEnabled = true;
            this.escolhasexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.escolhasexo.Location = new System.Drawing.Point(359, 129);
            this.escolhasexo.Name = "escolhasexo";
            this.escolhasexo.Size = new System.Drawing.Size(142, 28);
            this.escolhasexo.TabIndex = 0;
            this.escolhasexo.Text = "Sexo";
            // 
            // txbsobrenome
            // 
            this.txbsobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbsobrenome.Location = new System.Drawing.Point(220, 76);
            this.txbsobrenome.Name = "txbsobrenome";
            this.txbsobrenome.Size = new System.Drawing.Size(317, 26);
            this.txbsobrenome.TabIndex = 2;
            this.txbsobrenome.Text = "Digite o seu sobrenome";
            this.txbsobrenome.Click += new System.EventHandler(this.txbsobrenome_Click);
            // 
            // txbidade
            // 
            this.txbidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbidade.Location = new System.Drawing.Point(115, 131);
            this.txbidade.Name = "txbidade";
            this.txbidade.Size = new System.Drawing.Size(144, 26);
            this.txbidade.TabIndex = 4;
            this.txbidade.Click += new System.EventHandler(this.txbidade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Altura";
            // 
            // txbAltura
            // 
            this.txbAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAltura.Location = new System.Drawing.Point(115, 191);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(144, 26);
            this.txbAltura.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Peso";
            // 
            // txbPeso
            // 
            this.txbPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPeso.Location = new System.Drawing.Point(115, 232);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(144, 26);
            this.txbPeso.TabIndex = 8;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(434, 340);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(109, 56);
            this.btncalcular.TabIndex = 9;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txbnome
            // 
            this.txbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnome.Location = new System.Drawing.Point(55, 76);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(144, 26);
            this.txbnome.TabIndex = 10;
            this.txbnome.Text = "Digite o seu nome";
            this.txbnome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbnome_MouseClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(319, 340);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(109, 56);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Idade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbnome);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbidade);
            this.Controls.Add(this.txbsobrenome);
            this.Controls.Add(this.escolhasexo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox escolhasexo;
        private System.Windows.Forms.TextBox txbsobrenome;
        private System.Windows.Forms.TextBox txbidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
    }
}

