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
    public partial class frmCadastraPessoa : Form
    {
        public frmCadastraPessoa()
        {
            InitializeComponent();
            carregaCabecalho();
        }

        DataTable dt = new DataTable();

        public void carregaCabecalho()
        {
            dt.Columns.Add("Código", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("E-mail", typeof(string));
            dt.Columns.Add("CPF", typeof(string));
            dt.Columns.Add("Telefone", typeof(string));

            dgvDadosPessoais.DataSource = dt;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtCodigo.Text, txtNome.Text, txtEmail.Text, mskCPF.Text, mskTelefone.Text);
            dgvDadosPessoais.DataSource = dt;
            limparCampos();

        }

        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            mskCPF.Text = "";
            mskTelefone.Text = "";
            txtCodigo.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvDadosPessoais.CurrentRow != null)
            {
                int linha = dgvDadosPessoais.CurrentCell.RowIndex;
                dgvDadosPessoais.Rows.RemoveAt(linha);
            }
            else
            {
                MessageBox.Show("Dados excluídos");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            dgvDadosPessoais.DataSource = dt;
        }

        private void dgvDadosPessoais_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Text = dgvDadosPessoais.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvDadosPessoais.CurrentRow.Cells[1].Value.ToString();
                txtEmail.Text = dgvDadosPessoais.CurrentRow.Cells[2].Value.ToString();
                mskCPF.Text = dgvDadosPessoais.CurrentRow.Cells[3].Value.ToString();
                mskTelefone.Text = dgvDadosPessoais.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Dados inválidos!!!");
            }

        }
    }
}
