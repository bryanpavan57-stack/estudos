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
            this.tbNome = new TextBox();
            tbCategoria = new TextBox();
            tbQuantidade = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btCadastrar = new Button();
            btLimpar = new Button();
            dataGridView1 = new DataGridView();
            tbPreco = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new Point(47, 62);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new Size(133, 23);
            this.tbNome.TabIndex = 0;
            // 
            // tbCategoria
            // 
            tbCategoria.Location = new Point(47, 259);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(133, 23);
            tbCategoria.TabIndex = 3;
            // 
            // tbQuantidade
            // 
            tbQuantidade.Location = new Point(47, 195);
            tbQuantidade.Name = "tbQuantidade";
            tbQuantidade.Size = new Size(133, 23);
            tbQuantidade.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 44);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 108);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 177);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 9;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 241);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "label4";
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(298, 303);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(75, 23);
            btCadastrar.TabIndex = 12;
            btCadastrar.Text = "button1";
            btCadastrar.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(449, 303);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(75, 23);
            btLimpar.TabIndex = 13;
            btLimpar.Text = "button2";
            btLimpar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(227, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(389, 253);
            dataGridView1.TabIndex = 14;
            // 
            // tbPreco
            // 
            tbPreco.Location = new Point(47, 137);
            tbPreco.Name = "tbPreco";
            tbPreco.Size = new Size(133, 23);
            tbPreco.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbPreco);
            Controls.Add(dataGridView1);
            Controls.Add(btLimpar);
            Controls.Add(btCadastrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbQuantidade);
            Controls.Add(tbCategoria);
            Controls.Add(this.tbNome);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox tbPreco1995;
        private TextBox tbCategoria;
        private TextBox tbQuantidade;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btCadastrar;
        private Button btLimpar;
        private DataGridView dataGridView1;
        private TextBox tbPreco;
    }
}
