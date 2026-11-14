namespace Atividade2
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            decimal preco;
            int quantidade;

            if (tbNome.Text.Trim() == "")
            {
                MessageBox.Show("Informa o nome do produto.");
                return;
            }
            //preço precisa ser numero maior que zero
            if (decimal.TryParse(tbNome.Text, out preco) == false || preco <= 0)
            {
                MessageBox.Show("O preço deve ser maior do que zero.");
                return;
            }

            Produto p = new Produto();

            p.Nome = tbNome.Text.Trim();
            p.preco = preco;
            p.Estoque = Quantidade;
            p.Categoria = tbCategoria.Text.Trim();

        }

    }
}
