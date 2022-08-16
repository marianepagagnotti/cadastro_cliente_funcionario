using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_interface
{
    public partial class FrmBotoes : Form
    {
        public FrmBotoes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            //só permite usar o form1 qndo o form2 for fechado
            form2.ShowDialog();
        
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            //só permite usar o form1 qndo o form3 for fechado
            form3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
