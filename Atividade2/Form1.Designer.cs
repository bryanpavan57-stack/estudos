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
            tabPage2 = new TabPage();
            tbNome = new TextBox();
            tbCategoria = new TextBox();
            tbQuantidade = new TextBox();
            tbPreco = new TextBox();
            lbNome = new Label();
            lbPreco = new Label();
            lbQuantidade = new Label();
            lbCategoria = new Label();
            button1 = new Button();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(667, 303);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pedidos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(125, 11);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(231, 23);
            tbNome.TabIndex = 0;
            // 
            // tbCategoria
            // 
            tbCategoria.Location = new Point(125, 231);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(231, 23);
            tbCategoria.TabIndex = 1;
            // 
            // tbQuantidade
            // 
            tbQuantidade.Location = new Point(125, 160);
            tbQuantidade.Name = "tbQuantidade";
            tbQuantidade.Size = new Size(231, 23);
            tbQuantidade.TabIndex = 2;
            // 
            // tbPreco
            // 
            tbPreco.Location = new Point(125, 82);
            tbPreco.Name = "tbPreco";
            tbPreco.Size = new Size(231, 23);
            tbPreco.TabIndex = 3;
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
            // lbPreco
            // 
            lbPreco.AutoSize = true;
            lbPreco.Location = new Point(50, 85);
            lbPreco.Name = "lbPreco";
            lbPreco.Size = new Size(37, 15);
            lbPreco.TabIndex = 5;
            lbPreco.Text = "Preço";
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
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Location = new Point(50, 234);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(58, 15);
            lbCategoria.TabIndex = 7;
            lbCategoria.Text = "Categoria";
            // 
            // button1
            // 
            button1.Location = new Point(392, 226);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 8;
            button1.Text = "Cadastrar Produto";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(537, 226);
            button2.Name = "button2";
            button2.Size = new Size(124, 23);
            button2.TabIndex = 9;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
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
        private Button button2;
        private Button button1;
    }
}
