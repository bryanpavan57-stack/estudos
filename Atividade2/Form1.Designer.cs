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
            dgProdutos = new DataGridView();
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
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProdutos).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(25, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(675, 331);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgProdutos);
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
            tabPage1.Size = new Size(667, 303);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Produtos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgProdutos
            // 
            dgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProdutos.Location = new Point(392, 14);
            dgProdutos.Name = "dgProdutos";
            dgProdutos.Size = new Size(269, 240);
            dgProdutos.TabIndex = 10;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(537, 260);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(124, 23);
            btLimpar.TabIndex = 9;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
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
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(667, 303);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pedidos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(84, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(419, 45);
            dataGridView1.TabIndex = 0;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 67);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 102);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
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
            ((System.ComponentModel.ISupportInitialize)dgProdutos).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dgProdutos;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
