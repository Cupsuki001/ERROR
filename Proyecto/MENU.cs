namespace Proyecto
{
    public partial class MENU : Form
    {
        BalanceG balance = new BalanceG();
        Form3 nuevo = new Form3();
        Form4 resultado = new Form4();
        public MENU()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }



        private void estadoDeResultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultado.MdiParent = this;
            resultado.Show();
        }

        private void nuevoBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void mostrarBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balance.MdiParent = this;
            balance.Show();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }
    }
}