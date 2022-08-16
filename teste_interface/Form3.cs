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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       
        private void limpar()
        {
            txtCodigoFun.Clear();
            txtNomeFun.Clear();
            txtCPF.Clear();
            mskTelFun.Clear();
            txtBairroFun.Clear();
            txtRuaFun.Clear();
            txtNumeroFun.Clear();
            txtCodigoFun.Focus();
            comboBoxCompl.Text = "";
            comboBoxCidade.Text = "";
        }
        
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrarFun_Click(object sender, EventArgs e)
        {
            if (txtCodigoFun.Text == "")
            {
                MessageBox.Show("Código não pode estar vazio!");
                txtCodigoFun.Focus();
                return;
            }


            string[] funcionario = new string[9];
            funcionario[0] = txtCodigoFun.Text;
            funcionario[1] = txtNomeFun.Text;
            funcionario[2] = txtCPF.Text;
            funcionario[3] = mskTelFun.Text;
            funcionario[4] = txtBairroFun.Text;
            funcionario[5] = txtRuaFun.Text;
            funcionario[6] = txtNumeroFun.Text;
            funcionario[7] = comboBoxCompl.Text;
            funcionario[8] = comboBoxCidade.Text;


            ListViewItem l = new ListViewItem(funcionario);
            lv_funcionario.Items.Add(l);
            limpar();
        }

        private void btnResgatar_Click(object sender, EventArgs e)
        {
            txtCodigoFun.Text = lv_funcionario.SelectedItems[0].SubItems[0].Text;
            txtNomeFun.Text = lv_funcionario.SelectedItems[0].SubItems[1].Text;
            txtCPF.Text = lv_funcionario.SelectedItems[0].SubItems[2].Text;
            mskTelFun.Text = lv_funcionario.SelectedItems[0].SubItems[3].Text;
            txtBairroFun.Text = lv_funcionario.SelectedItems[0].SubItems[4].Text;
            txtRuaFun.Text = lv_funcionario.SelectedItems[0].SubItems[5].Text;
            txtNumeroFun.Text = lv_funcionario.SelectedItems[0].SubItems[6].Text;
            comboBoxCompl.Text = lv_funcionario.SelectedItems[0].SubItems[7].Text;
            comboBoxCidade.Text = lv_funcionario.SelectedItems[0].SubItems[8].Text;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            lv_funcionario.Items.RemoveAt(lv_funcionario.SelectedIndices[0]);

            txtCodigoFun.Clear();
            txtNomeFun.Clear();
            txtCPF.Clear();
            mskTelFun.Clear();
            txtBairroFun.Clear();
            txtRuaFun.Clear();
            txtNumeroFun.Clear();
            txtCodigoFun.Focus();
            comboBoxCompl.Text = "";
            comboBoxCidade.Text = "";

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBotoes novo = new FrmBotoes();
            novo.Show();
        }
    }
}
