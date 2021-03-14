namespace loja
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcioarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadProd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsProd = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodRestric = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeLogado = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.menuStrip1.Font = new System.Drawing.Font("Corbel", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcioarioToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funcioarioToolStripMenuItem
            // 
            this.funcioarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadFunc,
            this.menuConsFunc});
            this.funcioarioToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.funcioarioToolStripMenuItem.Name = "funcioarioToolStripMenuItem";
            this.funcioarioToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.funcioarioToolStripMenuItem.Text = "Funcionário";
            // 
            // menuCadFunc
            // 
            this.menuCadFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.menuCadFunc.ForeColor = System.Drawing.Color.White;
            this.menuCadFunc.Name = "menuCadFunc";
            this.menuCadFunc.Size = new System.Drawing.Size(134, 22);
            this.menuCadFunc.Text = "Cadastrar";
            this.menuCadFunc.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // menuConsFunc
            // 
            this.menuConsFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.menuConsFunc.ForeColor = System.Drawing.Color.White;
            this.menuConsFunc.Name = "menuConsFunc";
            this.menuConsFunc.Size = new System.Drawing.Size(134, 22);
            this.menuConsFunc.Text = "Consultar";
            this.menuConsFunc.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadProd,
            this.menuConsProd});
            this.produtoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // menuCadProd
            // 
            this.menuCadProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.menuCadProd.ForeColor = System.Drawing.Color.White;
            this.menuCadProd.Name = "menuCadProd";
            this.menuCadProd.Size = new System.Drawing.Size(134, 22);
            this.menuCadProd.Text = "Cadastrar";
            this.menuCadProd.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // menuConsProd
            // 
            this.menuConsProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.menuConsProd.ForeColor = System.Drawing.Color.White;
            this.menuConsProd.Name = "menuConsProd";
            this.menuConsProd.Size = new System.Drawing.Size(134, 22);
            this.menuConsProd.Text = "Consultar";
            this.menuConsProd.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsEstoque});
            this.estoqueToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // menuConsEstoque
            // 
            this.menuConsEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.menuConsEstoque.ForeColor = System.Drawing.Color.White;
            this.menuConsEstoque.Name = "menuConsEstoque";
            this.menuConsEstoque.Size = new System.Drawing.Size(131, 22);
            this.menuConsEstoque.Text = "Consultar";
            this.menuConsEstoque.Click += new System.EventHandler(this.consultarToolStripMenuItem2_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadVenda,
            this.menuConsVenda});
            this.vendaToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // menuCadVenda
            // 
            this.menuCadVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.menuCadVenda.ForeColor = System.Drawing.Color.White;
            this.menuCadVenda.Name = "menuCadVenda";
            this.menuCadVenda.Size = new System.Drawing.Size(152, 22);
            this.menuCadVenda.Text = "Incluir";
            this.menuCadVenda.Click += new System.EventHandler(this.consultarToolStripMenuItem3_Click);
            // 
            // menuConsVenda
            // 
            this.menuConsVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.menuConsVenda.ForeColor = System.Drawing.Color.White;
            this.menuConsVenda.Name = "menuConsVenda";
            this.menuConsVenda.Size = new System.Drawing.Size(152, 22);
            this.menuConsVenda.Text = "Consultar";
            this.menuConsVenda.Click += new System.EventHandler(this.consultarToolStripMenuItem4_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem1,
            this.estoqueToolStripMenuItem1,
            this.vendaToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.produtoToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.produtoToolStripMenuItem1.Text = "Produto";
            this.produtoToolStripMenuItem1.Click += new System.EventHandler(this.produtoToolStripMenuItem1_Click);
            // 
            // estoqueToolStripMenuItem1
            // 
            this.estoqueToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.estoqueToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
            this.estoqueToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.estoqueToolStripMenuItem1.Text = "Estoque";
            this.estoqueToolStripMenuItem1.Click += new System.EventHandler(this.estoqueToolStripMenuItem1_Click);
            // 
            // vendaToolStripMenuItem1
            // 
            this.vendaToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.vendaToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.vendaToolStripMenuItem1.Name = "vendaToolStripMenuItem1";
            this.vendaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.vendaToolStripMenuItem1.Text = "Venda";
            this.vendaToolStripMenuItem1.Click += new System.EventHandler(this.vendaToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seja Bem Vindo";
            // 
            // txtCodRestric
            // 
            this.txtCodRestric.AutoSize = true;
            this.txtCodRestric.Location = new System.Drawing.Point(34, 44);
            this.txtCodRestric.Name = "txtCodRestric";
            this.txtCodRestric.Size = new System.Drawing.Size(35, 13);
            this.txtCodRestric.TabIndex = 6;
            this.txtCodRestric.Text = "label2";
            this.txtCodRestric.Visible = false;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtCpf.ForeColor = System.Drawing.Color.White;
            this.txtCpf.Location = new System.Drawing.Point(169, 220);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(289, 21);
            this.txtCpf.TabIndex = 70;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Corbel", 14F);
            this.lblCpf.Location = new System.Drawing.Point(165, 194);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(47, 23);
            this.lblCpf.TabIndex = 69;
            this.lblCpf.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Corbel", 10.25F);
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(169, 165);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(289, 24);
            this.txtNome.TabIndex = 68;
            // 
            // lblNomeLogado
            // 
            this.lblNomeLogado.AutoSize = true;
            this.lblNomeLogado.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeLogado.Font = new System.Drawing.Font("Corbel", 14F);
            this.lblNomeLogado.Location = new System.Drawing.Point(165, 139);
            this.lblNomeLogado.Name = "lblNomeLogado";
            this.lblNomeLogado.Size = new System.Drawing.Size(63, 23);
            this.lblNomeLogado.TabIndex = 67;
            this.lblNomeLogado.Text = "Nome:";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(631, 296);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomeLogado);
            this.Controls.Add(this.txtCodRestric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funcioarioToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menuCadFunc;
        public System.Windows.Forms.ToolStripMenuItem menuConsFunc;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menuCadProd;
        public System.Windows.Forms.ToolStripMenuItem menuConsProd;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menuConsEstoque;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menuCadVenda;
        public System.Windows.Forms.ToolStripMenuItem menuConsVenda;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label txtCodRestric;
        public System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeLogado;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem1;
    }
}