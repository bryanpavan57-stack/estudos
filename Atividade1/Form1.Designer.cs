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
            tbNome.Location = new Point(99, 55);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(118, 23);
            tbNome.TabIndex = 0;
            // 
            // tbCategoria
            // 
            tbCategoria.Location = new Point(99, 213);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(118, 23);
            tbCategoria.TabIndex = 1;
            // 
            // tbQuantidade
            // 
            tbQuantidade.Location = new Point(99, 163);
            tbQuantidade.Name = "tbQuantidade";
            tbQuantidade.Size = new Size(118, 23);
            tbQuantidade.TabIndex = 2;
            // 
            // tbPreco
            // 
            tbPreco.Location = new Point(99, 108);
            tbPreco.Name = "tbPreco";
            tbPreco.Size = new Size(118, 23);
            tbPreco.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 58);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 111);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "Preço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 216);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 166);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 8;
            label5.Text = "Quantidade";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(579, 303);
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(627, 303);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Produtos";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 10);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 16;
            label2.Text = "Produtos Cadastrados";
            // 
            // dgLista
            // 
            dgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLista.Location = new Point(232, 28);
            dgLista.Name = "dgLista";
            dgLista.Size = new Size(376, 247);
            dgLista.TabIndex = 15;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(142, 252);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(75, 23);
            btLimpar.TabIndex = 14;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(44, 252);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(75, 23);
            btCadastrar.TabIndex = 13;
            btCadastrar.Text = "Cadastar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click_1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(54, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(635, 331);
            tabControl1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 450);
            Controls.Add(tabControl1);
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
