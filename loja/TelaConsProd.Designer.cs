namespace loja
{
    partial class TelaConsProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaConsProd));
            this.txtEstoque = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDtCompra = new System.Windows.Forms.DateTimePicker();
            this.txtDtCad = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.MaskedTextBox();
            this.txtPreco = new System.Windows.Forms.MaskedTextBox();
            this.txtCusto = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigoBarra = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstoque
            // 
            this.txtEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtEstoque.ForeColor = System.Drawing.Color.White;
            this.txtEstoque.Location = new System.Drawing.Point(485, 190);
            this.txtEstoque.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(94, 20);
            this.txtEstoque.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(482, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Estoque:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(317, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Código de Barras:";
            // 
            // txtDtCompra
            // 
            this.txtDtCompra.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtDtCompra.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtDtCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDtCompra.Location = new System.Drawing.Point(485, 134);
            this.txtDtCompra.Name = "txtDtCompra";
            this.txtDtCompra.Size = new System.Drawing.Size(94, 20);
            this.txtDtCompra.TabIndex = 8;
            // 
            // txtDtCad
            // 
            this.txtDtCad.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtDtCad.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtDtCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDtCad.Location = new System.Drawing.Point(485, 81);
            this.txtDtCad.Name = "txtDtCad";
            this.txtDtCad.Size = new System.Drawing.Size(94, 20);
            this.txtDtCad.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(482, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Data do Cadastro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(482, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Data da Compra:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtFornecedor.ForeColor = System.Drawing.Color.White;
            this.txtFornecedor.Location = new System.Drawing.Point(25, 190);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(218, 20);
            this.txtFornecedor.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(22, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Fornecedor:";
            // 
            // cboTipo
            // 
            this.cboTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.cboTipo.ForeColor = System.Drawing.Color.White;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.ItemHeight = 13;
            this.cboTipo.Location = new System.Drawing.Point(270, 189);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(194, 21);
            this.cboTipo.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(265, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Tipo:";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtMarca.ForeColor = System.Drawing.Color.White;
            this.txtMarca.Location = new System.Drawing.Point(270, 137);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(194, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(267, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Marca:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(145, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Custo:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtDescricao.ForeColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(25, 245);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(262, 23);
            this.txtDescricao.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(402, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Qtde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(22, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Descrição:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtNomeProduto.ForeColor = System.Drawing.Color.White;
            this.txtNomeProduto.Location = new System.Drawing.Point(147, 84);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(233, 20);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(144, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cód. Produto:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtQuantidade.ForeColor = System.Drawing.Color.White;
            this.txtQuantidade.Location = new System.Drawing.Point(405, 84);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(59, 20);
            this.txtQuantidade.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(196, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = "Consulta de Produtos";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Corbel", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.btnLimpar.Location = new System.Drawing.Point(120, 296);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 40);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Corbel", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.btnConsultar.Location = new System.Drawing.Point(221, 296);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 40);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Corbel", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.btnAlterar.Location = new System.Drawing.Point(320, 296);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 40);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Corbel", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.btnExcluir.Location = new System.Drawing.Point(425, 296);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 40);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(22, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Preço:";
            // 
            // txtCodProd
            // 
            this.txtCodProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtCodProd.ForeColor = System.Drawing.Color.White;
            this.txtCodProd.Location = new System.Drawing.Point(25, 84);
            this.txtCodProd.Mask = "0000";
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(101, 20);
            this.txtCodProd.TabIndex = 1;
            this.txtCodProd.ValidatingType = typeof(int);
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtPreco.ForeColor = System.Drawing.Color.White;
            this.txtPreco.Location = new System.Drawing.Point(25, 137);
            this.txtPreco.Mask = "000.00";
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(101, 20);
            this.txtPreco.TabIndex = 5;
            // 
            // txtCusto
            // 
            this.txtCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtCusto.ForeColor = System.Drawing.Color.White;
            this.txtCusto.Location = new System.Drawing.Point(148, 137);
            this.txtCusto.Mask = "000.00";
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(95, 20);
            this.txtCusto.TabIndex = 6;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtCodigoBarra.ForeColor = System.Drawing.Color.White;
            this.txtCodigoBarra.Location = new System.Drawing.Point(320, 245);
            this.txtCodigoBarra.Mask = "0000000";
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(259, 20);
            this.txtCodigoBarra.TabIndex = 13;
            // 
            // TelaConsProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 359);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDtCompra);
            this.Controls.Add(this.txtDtCad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TelaConsProd";
            this.Text = "Consulta de Produtos";
            this.Load += new System.EventHandler(this.TelaConsProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtEstoque;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker txtDtCompra;
        private System.Windows.Forms.DateTimePicker txtDtCad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCodProd;
        private System.Windows.Forms.MaskedTextBox txtPreco;
        private System.Windows.Forms.MaskedTextBox txtCusto;
        private System.Windows.Forms.MaskedTextBox txtCodigoBarra;
    }
}