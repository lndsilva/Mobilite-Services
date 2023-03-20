using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobilitec_Services
{
    public partial class frmPesquisaCliente : Form
    {
        public frmPesquisaCliente()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        //limpar campos

        public void limparCampos()
        {
            txtDescricao.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            ltbResultadoPesquisa.Items.Clear();
            txtDescricao.Focus();
            txtDescricao.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked && txtDescricao.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores para pesquisa",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                txtDescricao.Focus();

            }
            else if (rdbNome.Checked && txtDescricao.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores para pesquisa",
                     "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                    );
                txtDescricao.Focus();

            }
            else
            {
                ltbResultadoPesquisa.Items.Clear();
                ltbResultadoPesquisa.Items.Add(txtDescricao.Text);
            }

        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }

        private void ltbResultadoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string resp = ltbResultadoPesquisa.SelectedItem.ToString();

            frmClientes abrir = new frmClientes(resp);
            abrir.Show();
            this.Hide();
        }
    }
}
