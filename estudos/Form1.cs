namespace estudos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<object> pessoas = new List<object>();

        private void button1_Click(object sender, EventArgs e)
        {
            var pessoa = new { nome = tbNome.Text, cidade = tbCidade.Text };



            pessoas.Add(pessoa);

            dtResultado.DataSource = null;
            dtResultado.DataSource = pessoas;

        }
    }
}
