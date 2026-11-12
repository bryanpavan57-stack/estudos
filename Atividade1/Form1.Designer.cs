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
            btCadastrar = new Button();
            btLimpar = new Button();
            dgLista = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgLista).BeginInit();
            SuspendLayout();
            // 
            // tbNome
            // 
            tbNome.Location = new Point(45, 69);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(132, 23);
            tbNome.TabIndex = 0;
            // 
            // tbCategoria
            // 
            tbCategoria.Location = new Point(45, 252);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(132, 23);
            tbCategoria.TabIndex = 1;
            // 
            // tbQuantidade
            // 
            tbQuantidade.Location = new Point(45, 196);
            tbQuantidade.Name = "tbQuantidade";
            tbQuantidade.Size = new Size(132, 23);
            tbQuantidade.TabIndex = 2;
            // 
            // tbPreco
            // 
            tbPreco.Location = new Point(45, 128);
            tbPreco.Name = "tbPreco";
            tbPreco.Size = new Size(132, 23);
            tbPreco.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 51);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 110);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "Preco";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 234);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 178);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 8;
            label5.Text = "Quantidade";
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(317, 296);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(75, 23);
            btCadastrar.TabIndex = 9;
            btCadastrar.Text = "Cadastar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(441, 296);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(75, 23);
            btLimpar.TabIndex = 10;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // dgLista
            // 
            dgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLista.Location = new Point(230, 43);
            dgLista.Name = "dgLista";
            dgLista.Size = new Size(376, 232);
            dgLista.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 25);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 12;
            label2.Text = "Lista de Itens";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(dgLista);
            Controls.Add(btLimpar);
            Controls.Add(btCadastrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(tbPreco);
            Controls.Add(tbQuantidade);
            Controls.Add(tbCategoria);
            Controls.Add(tbNome);
            Name = "Form1";
            Text = "Form1";
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)dgLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btCadastrar;
        private Button btLimpar;
        private DataGridView dgLista;
        private Label label2;
    }
}
