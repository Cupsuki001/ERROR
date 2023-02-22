using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class BalanceG : Form
    {
        public BalanceG()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TXBTcapital.Enabled = false;
            TXBTactivo.Enabled = false;
            TXBTpasivo.Enabled = false; 
            TXBigualA.Enabled = false;
            TXBigualB.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
