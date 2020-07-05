namespace loja
{
    partial class TelaCadVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadVenda));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataCompra = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.txtDesconto = new System.Windows.Forms.MaskedTextBox();
            this.txtValorParcela = new System.Windows.Forms.MaskedTextBox();
            this.txtValorUnitario = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkParcelado = new System.Windows.Forms.CheckBox();
            this.txtCodigoBarra = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.txtParcelas = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboTipoPagamento = new System.Windows.Forms.ComboBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.txtCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfVendedor = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtCliente.ForeColor = System.Drawing.Color.White;
            this.txtCliente.Location = new System.Drawing.Point(26, 66);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(197, 23);
            this.txtCliente.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(248, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF:";
            // 
            // txtVendedor
            // 
            this.txtVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtVendedor.Enabled = false;
            this.txtVendedor.ForeColor = System.Drawing.Color.White;
            this.txtVendedor.Location = new System.Drawing.Point(26, 110);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(197, 23);
            this.txtVendedor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(23, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vendedor:";
            // 
            // txtDataCompra
            // 
            this.txtDataCompra.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtDataCompra.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataCompra.Location = new System.Drawing.Point(384, 63);
            this.txtDataCompra.Name = "txtDataCompra";
            this.txtDataCompra.Size = new System.Drawing.Size(100, 23);
            this.txtDataCompra.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(381, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data da Compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(248, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "CPF:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtValorTotal);
            this.groupBox2.Controls.Add(this.txtDesconto);
            this.groupBox2.Controls.Add(this.txtValorParcela);
            this.groupBox2.Controls.Add(this.txtValorUnitario);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.chkParcelado);
            this.groupBox2.Controls.Add(this.txtCodigoBarra);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.txtParcelas);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cboTipoPagamento);
            this.groupBox2.Controls.Add(this.txtProduto);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 270);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Pedido";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.ForeColor = System.Drawing.Color.White;
            this.txtValorTotal.Location = new System.Drawing.Point(27, 222);
            this.txtValorTotal.Mask = "000.00";
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(120, 23);
            this.txtValorTotal.TabIndex = 76;
            // 
            // txtDesconto
            // 
            this.txtDesconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtDesconto.ForeColor = System.Drawing.Color.White;
            this.txtDesconto.Location = new System.Drawing.Point(330, 164);
            this.txtDesconto.Mask = "000.00";
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(124, 23);
            this.txtDesconto.TabIndex = 75;
            this.txtDesconto.MouseHover += new System.EventHandler(this.txtDesconto_MouseHover);
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtValorParcela.Enabled = false;
            this.txtValorParcela.ForeColor = System.Drawing.Color.White;
            this.txtValorParcela.Location = new System.Drawing.Point(175, 164);
            this.txtValorParcela.Mask = "000.00";
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.Size = new System.Drawing.Size(124, 23);
            this.txtValorParcela.TabIndex = 74;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtValorUnitario.ForeColor = System.Drawing.Color.White;
            this.txtValorUnitario.Location = new System.Drawing.Point(27, 164);
            this.txtValorUnitario.Mask = "000.00";
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(120, 23);
            this.txtValorUnitario.TabIndex = 73;            
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(172, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 72;
            this.label7.Text = "Valor Parcela:";
            // 
            // chkParcelado
            // 
            this.chkParcelado.AutoSize = true;
            this.chkParcelado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkParcelado.Location = new System.Drawing.Point(327, 112);
            this.chkParcelado.Name = "chkParcelado";
            this.chkParcelado.Size = new System.Drawing.Size(78, 19);
            this.chkParcelado.TabIndex = 11;
            this.chkParcelado.Text = "Parcelado";
            this.chkParcelado.UseVisualStyleBackColor = true;
            this.chkParcelado.CheckedChanged += new System.EventHandler(this.chkParcelado_CheckedChanged);
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtCodigoBarra.ForeColor = System.Drawing.Color.White;
            this.txtCodigoBarra.Location = new System.Drawing.Point(27, 110);
            this.txtCodigoBarra.Mask = "0000000";
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(120, 23);
            this.txtCodigoBarra.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(27, 53);
            this.txtCodigo.Mask = "0000";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(120, 23);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtParcelas
            // 
            this.txtParcelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtParcelas.Enabled = false;
            this.txtParcelas.ForeColor = System.Drawing.Color.White;
            this.txtParcelas.Location = new System.Drawing.Point(426, 109);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(79, 23);
            this.txtParcelas.TabIndex = 12;
            this.txtParcelas.ValueChanged += new System.EventHandler(this.txtParcelas_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(423, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 15);
            this.label12.TabIndex = 61;
            this.label12.Text = "Nº Parcelas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(327, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 57;
            this.label10.Text = "Desconto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 55;
            this.label8.Text = "Valor Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(27, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 53;
            this.label9.Text = "Valor Unitário:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(24, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 15);
            this.label15.TabIndex = 47;
            this.label15.Text = "Código de Barras:";
            // 
            // cboTipoPagamento
            // 
            this.cboTipoPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.cboTipoPagamento.ForeColor = System.Drawing.Color.White;
            this.cboTipoPagamento.FormattingEnabled = true;
            this.cboTipoPagamento.Location = new System.Drawing.Point(175, 110);
            this.cboTipoPagamento.Name = "cboTipoPagamento";
            this.cboTipoPagamento.Size = new System.Drawing.Size(124, 22);
            this.cboTipoPagamento.TabIndex = 10;
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtProduto.ForeColor = System.Drawing.Color.White;
            this.txtProduto.Location = new System.Drawing.Point(175, 53);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(230, 23);
            this.txtProduto.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(172, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 15);
            this.label16.TabIndex = 44;
            this.label16.Text = "Produto:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(24, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 15);
            this.label17.TabIndex = 42;
            this.label17.Text = "Código do Produto:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(172, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 15);
            this.label18.TabIndex = 41;
            this.label18.Text = "Tipo de Pagamento:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtQuantidade.ForeColor = System.Drawing.Color.White;
            this.txtQuantidade.Location = new System.Drawing.Point(426, 53);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(79, 23);
            this.txtQuantidade.TabIndex = 8;
            this.txtQuantidade.ValueChanged += new System.EventHandler(this.txtQuantidade_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(423, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 15);
            this.label19.TabIndex = 39;
            this.label19.Text = "Quantidade:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Corbel", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.btnCadastrar.Location = new System.Drawing.Point(212, 445);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(119, 35);
            this.btnCadastrar.TabIndex = 30;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.MouseHover += new System.EventHandler(this.btnCadastrar_MouseHover);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vScrollBar1.Location = new System.Drawing.Point(550, -1);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 491);
            this.vScrollBar1.TabIndex = 23;
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtCpfCliente.ForeColor = System.Drawing.Color.White;
            this.txtCpfCliente.Location = new System.Drawing.Point(251, 66);
            this.txtCpfCliente.Mask = "000.000.000-00";
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(100, 23);
            this.txtCpfCliente.TabIndex = 2;
            // 
            // txtCpfVendedor
            // 
            this.txtCpfVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtCpfVendedor.Enabled = false;
            this.txtCpfVendedor.ForeColor = System.Drawing.Color.White;
            this.txtCpfVendedor.Location = new System.Drawing.Point(251, 110);
            this.txtCpfVendedor.Mask = "000.000.000-00";
            this.txtCpfVendedor.Name = "txtCpfVendedor";
            this.txtCpfVendedor.Size = new System.Drawing.Size(100, 23);
            this.txtCpfVendedor.TabIndex = 5;
            // 
            // TelaCadVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 508);
            this.Controls.Add(this.txtCpfVendedor);
            this.Controls.Add(this.txtCpfCliente);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDataCompra);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 9.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadVenda";
            this.Text = "Cadastrar Venda";
            this.Load += new System.EventHandler(this.TelaCadVenda_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtDataCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboTipoPagamento;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown txtParcelas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.MaskedTextBox txtCodigoBarra;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox txtCpfCliente;
        public System.Windows.Forms.MaskedTextBox txtCpfVendedor;
        private System.Windows.Forms.CheckBox chkParcelado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtValorTotal;
        private System.Windows.Forms.MaskedTextBox txtDesconto;
        private System.Windows.Forms.MaskedTextBox txtValorParcela;
        private System.Windows.Forms.MaskedTextBox txtValorUnitario;
    }
}