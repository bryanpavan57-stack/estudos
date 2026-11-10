namespace estudos
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
            tbIdade = new TextBox();
            tbCidade = new TextBox();
            tbAtivo = new TextBox();
            nome = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            dtResultado = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtResultado).BeginInit();
            SuspendLayout();
            // 
            // tbNome
            // 
            tbNome.Location = new Point(12, 43);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(132, 23);
            tbNome.TabIndex = 0;
            // 
            // tbIdade
            // 
            tbIdade.Location = new Point(12, 99);
            tbIdade.Name = "tbIdade";
            tbIdade.Size = new Size(132, 23);
            tbIdade.TabIndex = 1;
            // 
            // tbCidade
            // 
            tbCidade.Location = new Point(12, 165);
            tbCidade.Name = "tbCidade";
            tbCidade.Size = new Size(132, 23);
            tbCidade.TabIndex = 2;
            // 
            // tbAtivo
            // 
            tbAtivo.Location = new Point(12, 231);
            tbAtivo.Name = "tbAtivo";
            tbAtivo.Size = new Size(132, 23);
            tbAtivo.TabIndex = 3;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(41, 25);
            nome.Name = "nome";
            nome.Size = new Size(38, 15);
            nome.TabIndex = 4;
            nome.Text = "nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 81);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "idade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 147);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "cidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 213);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "ativo";
            // 
            // button1
            // 
            button1.Location = new Point(453, 287);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtResultado
            // 
            dtResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtResultado.Location = new Point(189, 25);
            dtResultado.Name = "dtResultado";
            dtResultado.Size = new Size(400, 229);
            dtResultado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtResultado);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nome);
            Controls.Add(tbAtivo);
            Controls.Add(tbCidade);
            Controls.Add(tbIdade);
            Controls.Add(tbNome);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNome;
        private TextBox tbIdade;
        private TextBox tbCidade;
        private TextBox tbAtivo;
        private Label nome;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private DataGridView dtResultado;
    }
}
