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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtCodCliente.Clear();
            txtNomeCli.Clear();
            mskDataNasc.Clear();
            msktxtTelCli.Clear();
            txtBairroCli.Clear();
            txtRuaCli.Clear();
            txtNumero.Clear();
            txtCodCliente.Focus();
            comboBoxCompl.Text = "";
            comboBoxCidade.Text = "";
        }
        
        private void btnCadastrarCli_Click(object sender, EventArgs e)
        {
            if(txtCodCliente.Text == "")
            {
                MessageBox.Show("Código não pode estar vazio!");
                txtCodCliente.Focus();
                return;
            }
            
            
            string[] cliente = new string[9];
            cliente[0] = txtCodCliente.Text;
            cliente[1] = txtNomeCli.Text;
            cliente[2] = mskDataNasc.Text;
            cliente[3] = msktxtTelCli.Text;
            cliente[4] = txtBairroCli.Text;
            cliente[5] = txtRuaCli.Text;
            cliente[6] = txtNumero.Text;
            cliente[7] = comboBoxCompl.Text;
            cliente[8] = comboBoxCidade.Text;
            
            
            ListViewItem l = new ListViewItem(cliente);
            lv_cliente.Items.Add(l);
            limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            lv_cliente.Items.RemoveAt(lv_cliente.SelectedIndices[0]);

            txtCodCliente.Clear();
            txtNomeCli.Clear();
            mskDataNasc.Clear();
            msktxtTelCli.Clear();
            txtBairroCli.Clear();
            txtRuaCli.Clear();
            txtNumero.Clear();
            txtCodCliente.Focus();
            comboBoxCompl.Text = "";
            comboBoxCidade.Text = "";
        }

        private void btnResgatar_Click(object sender, EventArgs e)
        {
            txtCodCliente.Text = lv_cliente.SelectedItems[0].SubItems[0].Text;
            txtNomeCli.Text = lv_cliente.SelectedItems[0].SubItems[1].Text;
            mskDataNasc.Text = lv_cliente.SelectedItems[0].SubItems[2].Text;
            msktxtTelCli.Text = lv_cliente.SelectedItems[0].SubItems[3].Text;
            txtBairroCli.Text = lv_cliente.SelectedItems[0].SubItems[4].Text;
            txtRuaCli.Text = lv_cliente.SelectedItems[0].SubItems[5].Text;
            txtNumero.Text = lv_cliente.SelectedItems[0].SubItems[6].Text;
            comboBoxCompl.Text = lv_cliente.SelectedItems[0].SubItems[7].Text;
            comboBoxCidade.Text = lv_cliente.SelectedItems[0].SubItems[8].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmBotoes novo = new FrmBotoes();
            novo.Show();








            //FrmBotoes frmB = new FrmBotoes();
            //só permite usar o form1 qndo o form2 for fechado
            //frmB.ShowDialog();

            //Form2.Hide;
        }

        
    }
}
