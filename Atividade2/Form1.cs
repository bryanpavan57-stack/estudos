using System.Drawing.Text;

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
            decimal Preco;
            int quantidade;

            if (tbNome.Text.Trim() == "")
            {
                MessageBox.Show("Informa o nome do produto.");
                return;
            }

            if (decimal.TryParse(tbPreco.Text, out Preco) == false || Preco <= 0)
            {
                MessageBox.Show("O preço deve ser maior do que zero.");
                return;
            }

            if (int.TryParse(tbQuantidade.Text, out quantidade) == false || quantidade < 0)
            {
                MessageBox.Show("Aquantidade deve ser um numero inteiro maior ou igual a zero.");
                return;
            }

            if (tbCategoria.Text.Trim() == "")
            {
                MessageBox.Show("Informe a categoria");
                return;
            }
            Produto p = new Produto();

            p.Nome = tbNome.Text.Trim();
            p.preco = Preco;
            p.Estoque = quantidade;
            p.Categoria = tbCategoria.Text.Trim();

            produtos.Add(p);
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            dgLista.DataSource = null;
            dgLista.DataSource = produtos;
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbNome.Clear();
            tbCategoria.Clear();
            tbPreco.Clear();
            tbQuantidade.Clear();
        }
    }
}
