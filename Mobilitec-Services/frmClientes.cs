﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Mobilitec_Services
{
    public partial class frmClientes : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmClientes()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public frmClientes(string nome)
        {
            InitializeComponent();
            desabilitarCampos();
            txtNome.Text = nome;
            habilitarCamposPesquisa();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
        //criando método para desabilitarCampos
        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cbbEstado.Enabled = false;
            cbbSexo.Enabled = false;
            mkbCEP.Enabled = false;
            mkbCPF.Enabled = false;
            mkbTelefone.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        //criando método para habilitarCamposPesquisa
        public void habilitarCamposPesquisa()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cbbEstado.Enabled = true;
            cbbSexo.Enabled = true;
            mkbCEP.Enabled = true;
            mkbCPF.Enabled = true;
            mkbTelefone.Enabled = true;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;

            txtNome.Focus();
        }
        public void habilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cbbEstado.Enabled = true;
            cbbSexo.Enabled = true;
            mkbCEP.Enabled = true;
            mkbCPF.Enabled = true;
            mkbTelefone.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
        }

        //criando o método limparCampos
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbbEstado.Items.Clear();
            cbbEstado.Text = "";
            cbbSexo.Items.Clear();
            cbbSexo.Text = "";
            mkbCEP.Clear();
            mkbCPF.Clear();
            mkbTelefone.Clear();
            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCamposNovo();
            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || txtEndereco.Text.Equals("")
                || txtNumero.Text.Equals("") || txtBairro.Text.Equals("") || txtCidade.Text.Equals("")
                || mkbCPF.Text.Equals("   .   .   -") || mkbTelefone.Text.Equals("(  )      -")
                || mkbCEP.Text.Equals("     -") || cbbEstado.Text.Equals("") || cbbSexo.Text.Equals(""))
            {
                MessageBox.Show("Não é permitido campo vazio", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Cadastrado com sucesso.", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                desabilitarCampos();
                btnNovo.Enabled = true;
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //abrir a janela de pesquisar
            frmPesquisaCliente abrir = new frmPesquisaCliente();
            abrir.ShowDialog();
            this.Hide();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro alterado com sucesso.",
                "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            desabilitarCampos();
            limparCampos();

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja excluir?",
                "Mensagem do sistema", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
            {
                //Vai excluir
                MessageBox.Show("Excluido com sucesso",
                "Mensagem do sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                btnNovo.Enabled = true;

                limparCampos();
                desabilitarCampos();
            }
            else
            {
                txtNome.Focus();
            }

        }
        public void buscaCEP(string numCEP)
        {
            WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();

            WSCorreios.enderecoERP endereco = ws.consultaCEP(numCEP);

            txtEndereco.Text = endereco.end;
            txtBairro.Text = endereco.bairro;
            txtCidade.Text = endereco.cidade;
            cbbEstado.Text = endereco.uf;

        }
        private void mkbCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscaCEP(mkbCEP.Text);
                txtNumero.Focus();
            }
        }
    }
}


