namespace Atividade2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgLista = new DataGridView();
            btLimpar = new Button();
            btCadastrar = new Button();
            lbCategoria = new Label();
            lbQuantidade = new Label();
            lbPreco = new Label();
            lbNome = new Label();
            tbPreco = new TextBox();
            tbQuantidade = new TextBox();
            tbCategoria = new TextBox();
            tbNome = new TextBox();
            tabPage2 = new TabPage();
            dgPedidos = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            btLimparPedido = new Button();
            btFinalizar = new Button();
            lblTotal = new Label();
            lblEstoque = new Label();
            lblPreco = new Label();
            tbCliente = new TextBox();
            tbQuant = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbProdutos = new ComboBox();
            dgItens = new DataGridView();
            btAdicionar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLista).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgItens).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(25, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(698, 354);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgLista);
            tabPage1.Controls.Add(btLimpar);
            tabPage1.Controls.Add(btCadastrar);
            tabPage1.Controls.Add(lbCategoria);
            tabPage1.Controls.Add(lbQuantidade);
            tabPage1.Controls.Add(lbPreco);
            tabPage1.Controls.Add(lbNome);
            tabPage1.Controls.Add(tbPreco);
            tabPage1.Controls.Add(tbQuantidade);
            tabPage1.Controls.Add(tbCategoria);
            tabPage1.Controls.Add(tbNome);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(690, 326);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Produtos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgLista
            // 
            dgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLista.GridColor = Color.Aquamarine;
            dgLista.Location = new Point(392, 14);
            dgLista.Name = "dgLista";
            dgLista.Size = new Size(269, 240);
            dgLista.TabIndex = 10;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(537, 260);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(124, 23);
            btLimpar.TabIndex = 9;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(392, 260);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(124, 23);
            btCadastrar.TabIndex = 8;
            btCadastrar.Text = "Cadastrar Produto";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Location = new Point(50, 234);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(58, 15);
            lbCategoria.TabIndex = 7;
            lbCategoria.Text = "Categoria";
            // 
            // lbQuantidade
            // 
            lbQuantidade.AutoSize = true;
            lbQuantidade.Location = new Point(39, 160);
            lbQuantidade.Name = "lbQuantidade";
            lbQuantidade.Size = new Size(69, 15);
            lbQuantidade.TabIndex = 6;
            lbQuantidade.Text = "Quantidade";
            // 
            // lbPreco
            // 
            lbPreco.AutoSize = true;
            lbPreco.Location = new Point(50, 85);
            lbPreco.Name = "lbPreco";
            lbPreco.Size = new Size(37, 15);
            lbPreco.TabIndex = 5;
            lbPreco.Text = "Preço";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(16, 14);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(103, 15);
            lbNome.TabIndex = 4;
            lbNome.Text = "Nome do Produto";
            // 
            // tbPreco
            // 
            tbPreco.Location = new Point(125, 82);
            tbPreco.Name = "tbPreco";
            tbPreco.Size = new Size(231, 23);
            tbPreco.TabIndex = 3;
            // 
            // tbQuantidade
            // 
            tbQuantidade.Location = new Point(125, 160);
            tbQuantidade.Name = "tbQuantidade";
            tbQuantidade.Size = new Size(231, 23);
            tbQuantidade.TabIndex = 2;
            // 
            // tbCategoria
            // 
            tbCategoria.Location = new Point(125, 231);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(231, 23);
            tbCategoria.TabIndex = 1;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(125, 11);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(231, 23);
            tbNome.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btAdicionar);
            tabPage2.Controls.Add(dgPedidos);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(btLimparPedido);
            tabPage2.Controls.Add(btFinalizar);
            tabPage2.Controls.Add(lblTotal);
            tabPage2.Controls.Add(lblEstoque);
            tabPage2.Controls.Add(lblPreco);
            tabPage2.Controls.Add(tbCliente);
            tabPage2.Controls.Add(tbQuant);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(cbProdutos);
            tabPage2.Controls.Add(dgItens);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(690, 326);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pedidos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgPedidos
            // 
            dgPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPedidos.Location = new Point(6, 258);
            dgPedidos.Name = "dgPedidos";
            dgPedidos.Size = new Size(448, 45);
            dgPedidos.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 231);
            label8.Name = "label8";
            label8.Size = new Size(116, 15);
            label8.TabIndex = 16;
            label8.Text = "Histórico de pedidos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 3);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 15;
            label7.Text = "Novo pedido";
            // 
            // btLimparPedido
            // 
            btLimparPedido.Location = new Point(356, 186);
            btLimparPedido.Name = "btLimparPedido";
            btLimparPedido.Size = new Size(98, 23);
            btLimparPedido.TabIndex = 14;
            btLimparPedido.Text = "Limpar";
            btLimparPedido.UseVisualStyleBackColor = true;
            btLimparPedido.Click += button2_Click;
            // 
            // btFinalizar
            // 
            btFinalizar.Location = new Point(202, 186);
            btFinalizar.Name = "btFinalizar";
            btFinalizar.Size = new Size(134, 23);
            btFinalizar.TabIndex = 13;
            btFinalizar.Text = "Finalizar pedido";
            btFinalizar.UseVisualStyleBackColor = true;
            btFinalizar.Click += button1_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(15, 190);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total:";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Location = new Point(387, 67);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(52, 15);
            lblEstoque.TabIndex = 11;
            lblEstoque.Text = "Estoque:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(283, 67);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 10;
            lblPreco.Text = "Preço:";
            // 
            // tbCliente
            // 
            tbCliente.Location = new Point(93, 31);
            tbCliente.Name = "tbCliente";
            tbCliente.Size = new Size(361, 23);
            tbCliente.TabIndex = 8;
            // 
            // tbQuant
            // 
            tbQuant.Location = new Point(93, 99);
            tbQuant.Name = "tbQuant";
            tbQuant.Size = new Size(147, 23);
            tbQuant.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 102);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Quantidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 67);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Produto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 34);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Cliente:";
            // 
            // cbProdutos
            // 
            cbProdutos.FormattingEnabled = true;
            cbProdutos.Location = new Point(93, 64);
            cbProdutos.Name = "cbProdutos";
            cbProdutos.Size = new Size(147, 23);
            cbProdutos.TabIndex = 1;
            // 
            // dgItens
            // 
            dgItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgItens.Location = new Point(6, 130);
            dgItens.Name = "dgItens";
            dgItens.Size = new Size(448, 45);
            dgItens.TabIndex = 0;
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(283, 99);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(171, 21);
            btAdicionar.TabIndex = 18;
            btAdicionar.Text = "Adicionar";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgLista).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgItens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lbCategoria;
        private Label lbQuantidade;
        private Label lbPreco;
        private Label lbNome;
        private TextBox tbPreco;
        private TextBox tbQuantidade;
        private TextBox tbCategoria;
        private TextBox tbNome;
        private Button btLimpar;
        private Button btCadastrar;
        private DataGridView dgLista;
        private DataGridView dgItens;
        private ComboBox cbProdutos;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblEstoque;
        private Label lblPreco;
        private TextBox tbCliente;
        private TextBox tbQuant;
        private Label lblTotal;
        private Button btLimparPedido;
        private Button btFinalizar;
        private Label label8;
        private Label label7;
        private DataGridView dgPedidos;
        private Button btAdicionar;
    }
}
