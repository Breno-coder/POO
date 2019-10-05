namespace Questão_3
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
            this.escolha = new System.Windows.Forms.ComboBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.TxtAjuda = new System.Windows.Forms.TextBox();
            this.txtValorproducao = new System.Windows.Forms.TextBox();
            this.txtvalorvendas = new System.Windows.Forms.TextBox();
            this.txtvalordividas = new System.Windows.Forms.TextBox();
            this.txtvalorcredito = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtCodigoSetor = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // escolha
            // 
            this.escolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolha.FormattingEnabled = true;
            this.escolha.Items.AddRange(new object[] {
            "Fornecedor",
            "Vendedor",
            "Operario",
            "Administrador"});
            this.escolha.Location = new System.Drawing.Point(12, 12);
            this.escolha.Name = "escolha";
            this.escolha.Size = new System.Drawing.Size(179, 37);
            this.escolha.TabIndex = 0;
            this.escolha.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtsalario
            // 
            this.txtsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalario.Location = new System.Drawing.Point(12, 166);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(267, 33);
            this.txtsalario.TabIndex = 1;
            this.txtsalario.Text = "Salario Bruto";
            this.txtsalario.Click += new System.EventHandler(this.txtsalario_Click);
            this.txtsalario.TextChanged += new System.EventHandler(this.txtsalario_TextChanged);
            this.txtsalario.Enter += new System.EventHandler(this.txtCodigoSetor_Enter);
            this.txtsalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalario_KeyPress);
            // 
            // TxtAjuda
            // 
            this.TxtAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAjuda.Location = new System.Drawing.Point(12, 205);
            this.TxtAjuda.Name = "TxtAjuda";
            this.TxtAjuda.Size = new System.Drawing.Size(267, 33);
            this.TxtAjuda.TabIndex = 2;
            this.TxtAjuda.Text = "Valor da Ajuda de Custo";
            this.TxtAjuda.Click += new System.EventHandler(this.TxtAjuda_Click);
            this.TxtAjuda.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.TxtAjuda.Enter += new System.EventHandler(this.txtCodigoSetor_Enter);
            this.TxtAjuda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAjuda_KeyPress);
            // 
            // txtValorproducao
            // 
            this.txtValorproducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorproducao.Location = new System.Drawing.Point(12, 244);
            this.txtValorproducao.Name = "txtValorproducao";
            this.txtValorproducao.Size = new System.Drawing.Size(267, 33);
            this.txtValorproducao.TabIndex = 3;
            this.txtValorproducao.Text = "Valor da Produção";
            this.txtValorproducao.Click += new System.EventHandler(this.txtValorproducao_Click);
            this.txtValorproducao.Enter += new System.EventHandler(this.txtCodigoSetor_Enter);
            this.txtValorproducao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorproducao_KeyPress);
            // 
            // txtvalorvendas
            // 
            this.txtvalorvendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorvendas.Location = new System.Drawing.Point(12, 283);
            this.txtvalorvendas.Name = "txtvalorvendas";
            this.txtvalorvendas.Size = new System.Drawing.Size(267, 33);
            this.txtvalorvendas.TabIndex = 4;
            this.txtvalorvendas.Text = "Valor das Vendas";
            this.txtvalorvendas.Click += new System.EventHandler(this.txtvalorvendas_Click);
            this.txtvalorvendas.Enter += new System.EventHandler(this.txtCodigoSetor_Enter);
            this.txtvalorvendas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorvendas_KeyPress);
            // 
            // txtvalordividas
            // 
            this.txtvalordividas.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalordividas.Location = new System.Drawing.Point(521, 147);
            this.txtvalordividas.Name = "txtvalordividas";
            this.txtvalordividas.Size = new System.Drawing.Size(267, 33);
            this.txtvalordividas.TabIndex = 5;
            this.txtvalordividas.Text = "Valor das Dividas";
            this.txtvalordividas.Click += new System.EventHandler(this.txtvalordividas_Click);
            this.txtvalordividas.Enter += new System.EventHandler(this.txtCodigoSetor_Enter);
            this.txtvalordividas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalordividas_KeyPress);
            // 
            // txtvalorcredito
            // 
            this.txtvalorcredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorcredito.Location = new System.Drawing.Point(521, 108);
            this.txtvalorcredito.Name = "txtvalorcredito";
            this.txtvalorcredito.Size = new System.Drawing.Size(267, 33);
            this.txtvalorcredito.TabIndex = 6;
            this.txtvalorcredito.Text = "Valor do Credito";
            this.txtvalorcredito.Click += new System.EventHandler(this.txtvalorcredito_Click);
            this.txtvalorcredito.Enter += new System.EventHandler(this.txtCodigoSetor_Enter);
            this.txtvalorcredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorcredito_KeyPress);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(197, 12);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(591, 33);
            this.txtnome.TabIndex = 7;
            this.txtnome.Text = "Nome";
            this.txtnome.Click += new System.EventHandler(this.txtnome_Click);
            this.txtnome.Enter += new System.EventHandler(this.txtCodigoSetor_Enter);
            this.txtnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnome_KeyPress);
            // 
            // txttelefone
            // 
            this.txttelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefone.Location = new System.Drawing.Point(197, 51);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(289, 33);
            this.txttelefone.TabIndex = 8;
            this.txttelefone.Text = "Telefone";
            this.txttelefone.Click += new System.EventHandler(this.txttelefone_Click);
            this.txttelefone.Enter += new System.EventHandler(this.txtCodigoSetor_Enter);
            this.txttelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefone_KeyPress);
            // 
            // txtendereco
            // 
            this.txtendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendereco.Location = new System.Drawing.Point(499, 51);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(289, 33);
            this.txtendereco.TabIndex = 9;
            this.txtendereco.Text = "Endereço";
            this.txtendereco.Click += new System.EventHandler(this.txtendereco_Click);
            this.txtendereco.Enter += new System.EventHandler(this.txtCodigoSetor_Enter);
            // 
            // txtCodigoSetor
            // 
            this.txtCodigoSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoSetor.Location = new System.Drawing.Point(12, 127);
            this.txtCodigoSetor.Name = "txtCodigoSetor";
            this.txtCodigoSetor.Size = new System.Drawing.Size(267, 33);
            this.txtCodigoSetor.TabIndex = 10;
            this.txtCodigoSetor.Text = "Codigo do Setor";
            this.txtCodigoSetor.Enter += new System.EventHandler(this.txtCodigoSetor_Enter);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(713, 415);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(713, 386);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(75, 23);
            this.Limpar.TabIndex = 12;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCodigoSetor);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtvalorcredito);
            this.Controls.Add(this.txtvalordividas);
            this.Controls.Add(this.txtvalorvendas);
            this.Controls.Add(this.txtValorproducao);
            this.Controls.Add(this.TxtAjuda);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.escolha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox escolha;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox TxtAjuda;
        private System.Windows.Forms.TextBox txtValorproducao;
        private System.Windows.Forms.TextBox txtvalorvendas;
        private System.Windows.Forms.TextBox txtvalordividas;
        private System.Windows.Forms.TextBox txtvalorcredito;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtCodigoSetor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button Limpar;
    }
}

