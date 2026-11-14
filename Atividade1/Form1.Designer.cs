namespace Atividade1
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
            tbNome = new TextBox();
            tbCategoria = new TextBox();
            tbQuantidade = new TextBox();
            tbPreco = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            label2 = new Label();
            dgLista = new DataGridView();
            btLimpar = new Button();
            btCadastrar = new Button();
            tabControl1 = new TabControl();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLista).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tbNome
            // 
            tbNome.Location = new Point(113, 73);
            tbNome.Margin = new Padding(3, 4, 3, 4);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(134, 27);
            tbNome.TabIndex = 0;
            // 
            // tbCategoria
            // 
            tbCategoria.Location = new Point(113, 284);
            tbCategoria.Margin = new Padding(3, 4, 3, 4);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(134, 27);
            tbCategoria.TabIndex = 1;
            // 
            // tbQuantidade
            // 
            tbQuantidade.Location = new Point(113, 217);
            tbQuantidade.Margin = new Padding(3, 4, 3, 4);
            tbQuantidade.Name = "tbQuantidade";
            tbQuantidade.Size = new Size(134, 27);
            tbQuantidade.TabIndex = 2;
            // 
            // tbPreco
            // 
            tbPreco.Location = new Point(113, 144);
            tbPreco.Margin = new Padding(3, 4, 3, 4);
            tbPreco.Name = "tbPreco";
            tbPreco.Size = new Size(134, 27);
            tbPreco.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 77);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 148);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Preço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 288);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 7;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 221);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 8;
            label5.Text = "Quantidade";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(718, 388);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pedidos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(tbCategoria);
            tabPage1.Controls.Add(tbQuantidade);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(tbPreco);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(dgLista);
            tabPage1.Controls.Add(tbNome);
            tabPage1.Controls.Add(btLimpar);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(btCadastrar);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(718, 388);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Produtos";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 13);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 16;
            label2.Text = "Produtos Cadastrados";
            // 
            // dgLista
            // 
            dgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLista.Location = new Point(265, 37);
            dgLista.Margin = new Padding(3, 4, 3, 4);
            dgLista.Name = "dgLista";
            dgLista.RowHeadersWidth = 51;
            dgLista.Size = new Size(430, 329);
            dgLista.TabIndex = 15;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(162, 336);
            btLimpar.Margin = new Padding(3, 4, 3, 4);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(86, 31);
            btLimpar.TabIndex = 14;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(50, 336);
            btCadastrar.Margin = new Padding(3, 4, 3, 4);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(86, 31);
            btCadastrar.TabIndex = 13;
            btCadastrar.Text = "Cadastar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click_1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(62, 36);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(726, 421);
            tabControl1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 600);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgLista).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox tbNome;
        private TextBox tbCategoria;
        private TextBox tbQuantidade;
        private TextBox tbPreco;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private Label label2;
        private DataGridView dgLista;
        private Button btLimpar;
        private Button btCadastrar;
    }
}
