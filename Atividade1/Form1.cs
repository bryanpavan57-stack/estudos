using System.Runtime.InteropServices.ObjectiveC;

namespace Atividade1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        List<object> produtos = new List<object>();

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            object pessoa = new
            {
                Nome = tbNome.Text,
                Preco = tbPreco.Text,
                Quantidade = tbQuantidade.Text,
                Categoria = tbCategoria.Text,
            };
            produtos.Add(pessoa);
            dgLista.DataSource = null;
            dgLista.DataSource = produtos;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            produtos.Clear();
           
        }
    }
}
