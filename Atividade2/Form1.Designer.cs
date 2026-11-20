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
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            dataGridView2 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProdutos).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(690, 326);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pedidos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(93, 64);
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
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Produto:";
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
            // textBox1
            // 
            textBox1.Location = new Point(93, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(93, 31);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(272, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(264, 99);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(138, 23);
            textBox5.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 67);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 10;
            label4.Text = "Preço: R$ 80,00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 67);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 11;
            label5.Text = "Estoque: 10";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 190);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 12;
            label6.Text = "Total: R$ 355,00";
            // 
            // button1
            // 
            button1.Location = new Point(187, 186);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 13;
            button1.Text = "Finalizar pedido";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(327, 186);
            button2.Name = "button2";
            button2.Size = new Size(98, 23);
            button2.TabIndex = 14;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 231);
            label8.Name = "label8";
            label8.Size = new Size(116, 15);
            label8.TabIndex = 16;
            label8.Text = "Histórico de pedidos";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 258);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(419, 45);
            dataGridView2.TabIndex = 17;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private Label label5;
        private Label label4;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox1;
        private Label label6;
        private Button button2;
        private Button button1;
        private Label label8;
        private Label label7;
        private DataGridView dataGridView2;
    }
}
