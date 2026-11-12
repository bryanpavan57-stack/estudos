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
            this.Page1 = new TabControl();
            tbCadastro = new TabPage();
            tabPage2 = new TabPage();
            this.Page1.SuspendLayout();
            SuspendLayout();
            // 
            // Page1
            // 
            this.Page1.Controls.Add(tbCadastro);
            this.Page1.Controls.Add(tabPage2);
            this.Page1.Location = new Point(12, 12);
            this.Page1.Name = "Page1";
            this.Page1.SelectedIndex = 0;
            this.Page1.Size = new Size(613, 342);
            this.Page1.TabIndex = 0;
            // 
            // tbCadastro
            // 
            tbCadastro.Location = new Point(4, 24);
            tbCadastro.Name = "tbCadastro";
            tbCadastro.Padding = new Padding(3);
            tbCadastro.Size = new Size(605, 314);
            tbCadastro.TabIndex = 0;
            tbCadastro.Text = "Cadastro de Produtos";
            tbCadastro.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(605, 314);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(this.Page1);
            Name = "Form1";
            Text = "Form1";
            this.Page1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tpCadastro;
        private TabPage tbCadastro;
        private TabPage tabPage2;
    }
}
