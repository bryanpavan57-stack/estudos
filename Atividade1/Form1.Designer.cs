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
            bt = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // bt
            // 
            bt.Location = new Point(317, 296);
            bt.Name = "bt";
            bt.Size = new Size(75, 23);
            bt.TabIndex = 9;
            bt.Text = "button1";
            bt.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(441, 296);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(230, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(376, 232);
            dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(bt);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button bt;
        private Button button2;
        private DataGridView dataGridView1;
    }
}
