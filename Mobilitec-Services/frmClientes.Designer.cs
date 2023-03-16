
namespace Mobilitec_Services
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbInforCliente = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mkbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cbbSexo = new System.Windows.Forms.ComboBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.mkbCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.gpbInforCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlMenu.Controls.Add(this.btnLimpar);
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.btnPesquisar);
            this.pnlMenu.Controls.Add(this.btnExcluir);
            this.pnlMenu.Controls.Add(this.btnAlterar);
            this.pnlMenu.Controls.Add(this.btnCadastrar);
            this.pnlMenu.Controls.Add(this.btnNovo);
            this.pnlMenu.Location = new System.Drawing.Point(1, 479);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(784, 78);
            this.pnlMenu.TabIndex = 13;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(565, 15);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 51);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(675, 15);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 51);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(453, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 51);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(343, 15);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 51);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(231, 15);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 51);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(119, 15);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 51);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(5, 15);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 51);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // gpbInforCliente
            // 
            this.gpbInforCliente.Controls.Add(this.txtNumero);
            this.gpbInforCliente.Controls.Add(this.lblNumero);
            this.gpbInforCliente.Controls.Add(this.cbbEstado);
            this.gpbInforCliente.Controls.Add(this.lblEstado);
            this.gpbInforCliente.Controls.Add(this.txtCidade);
            this.gpbInforCliente.Controls.Add(this.lblCidade);
            this.gpbInforCliente.Controls.Add(this.mkbCEP);
            this.gpbInforCliente.Controls.Add(this.lblCEP);
            this.gpbInforCliente.Controls.Add(this.txtEndereco);
            this.gpbInforCliente.Controls.Add(this.lblEndereco);
            this.gpbInforCliente.Controls.Add(this.cbbSexo);
            this.gpbInforCliente.Controls.Add(this.lblSexo);
            this.gpbInforCliente.Controls.Add(this.mkbTelefone);
            this.gpbInforCliente.Controls.Add(this.lblTelefone);
            this.gpbInforCliente.Controls.Add(this.mkbCPF);
            this.gpbInforCliente.Controls.Add(this.lblCPF);
            this.gpbInforCliente.Controls.Add(this.txtEmail);
            this.gpbInforCliente.Controls.Add(this.lblEmail);
            this.gpbInforCliente.Controls.Add(this.txtNome);
            this.gpbInforCliente.Controls.Add(this.lblNome);
            this.gpbInforCliente.Controls.Add(this.txtCodigo);
            this.gpbInforCliente.Controls.Add(this.lblCodigo);
            this.gpbInforCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInforCliente.Location = new System.Drawing.Point(22, 17);
            this.gpbInforCliente.Name = "gpbInforCliente";
            this.gpbInforCliente.Size = new System.Drawing.Size(743, 443);
            this.gpbInforCliente.TabIndex = 0;
            this.gpbInforCliente.TabStop = false;
            this.gpbInforCliente.Text = "Informações do Cliente";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(8, 50);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(70, 47);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(8, 103);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(67, 100);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(321, 26);
            this.txtNome.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(406, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(465, 100);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 26);
            this.txtEmail.TabIndex = 4;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(8, 164);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF";
            // 
            // mkbCPF
            // 
            this.mkbCPF.Location = new System.Drawing.Point(57, 161);
            this.mkbCPF.Mask = "000,000,000-00";
            this.mkbCPF.Name = "mkbCPF";
            this.mkbCPF.Size = new System.Drawing.Size(121, 26);
            this.mkbCPF.TabIndex = 5;
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Location = new System.Drawing.Point(305, 161);
            this.mkbTelefone.Mask = "(00) 00000-0000";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(129, 26);
            this.mkbTelefone.TabIndex = 6;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(230, 164);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(461, 164);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(45, 20);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo";
            // 
            // cbbSexo
            // 
            this.cbbSexo.FormattingEnabled = true;
            this.cbbSexo.Location = new System.Drawing.Point(512, 160);
            this.cbbSexo.Name = "cbbSexo";
            this.cbbSexo.Size = new System.Drawing.Size(142, 28);
            this.cbbSexo.TabIndex = 7;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(92, 226);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(342, 26);
            this.txtEndereco.TabIndex = 8;
            this.txtEndereco.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(8, 229);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(78, 20);
            this.lblEndereco.TabIndex = 12;
            this.lblEndereco.Text = "Endereço";
            // 
            // mkbCEP
            // 
            this.mkbCEP.Location = new System.Drawing.Point(649, 226);
            this.mkbCEP.Mask = "00000-000";
            this.mkbCEP.Name = "mkbCEP";
            this.mkbCEP.Size = new System.Drawing.Size(86, 26);
            this.mkbCEP.TabIndex = 10;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(603, 229);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(41, 20);
            this.lblCEP.TabIndex = 14;
            this.lblCEP.Text = "CEP";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(73, 291);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(246, 26);
            this.txtCidade.TabIndex = 11;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(8, 294);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(59, 20);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade";
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(410, 290);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(122, 28);
            this.cbbEstado.TabIndex = 12;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(339, 294);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(512, 226);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(85, 26);
            this.txtNumero.TabIndex = 9;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(445, 229);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 20);
            this.lblNumero.TabIndex = 20;
            this.lblNumero.Text = "Número";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.gpbInforCliente);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.pnlMenu.ResumeLayout(false);
            this.gpbInforCliente.ResumeLayout(false);
            this.gpbInforCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gpbInforCliente;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.ComboBox cbbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.MaskedTextBox mkbTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mkbCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mkbCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
    }
}