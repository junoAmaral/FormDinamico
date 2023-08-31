namespace FormDinamico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void CarregaForm(Form form)
        {
            form.TopLevel = false;
            painel.Controls.Clear();
            painel.Controls.Add(form);
            form.Location =new Point(painel.Width / 2 - form.Width / 2, painel.Height / 2 - form.Height / 2);
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaForm(new Inicio_que_funciona()); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CarregaForm(new Login()); 
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            CarregaForm(new Inicio_que_funciona()); 
        }
    }
}