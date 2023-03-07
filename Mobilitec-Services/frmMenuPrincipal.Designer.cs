
namespace Mobilitec_Services
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnChamados = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnSAC = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChamados
            // 
            this.btnChamados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamados.Location = new System.Drawing.Point(37, 46);
            this.btnChamados.Name = "btnChamados";
            this.btnChamados.Size = new System.Drawing.Size(209, 190);
            this.btnChamados.TabIndex = 0;
            this.btnChamados.Text = "&Chamados";
            this.btnChamados.UseVisualStyleBackColor = true;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.Location = new System.Drawing.Point(290, 46);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(209, 190);
            this.btnFuncionarios.TabIndex = 1;
            this.btnFuncionarios.Text = "&Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(540, 46);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(209, 190);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "C&lientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnSAC
            // 
            this.btnSAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAC.Location = new System.Drawing.Point(540, 269);
            this.btnSAC.Name = "btnSAC";
            this.btnSAC.Size = new System.Drawing.Size(209, 190);
            this.btnSAC.TabIndex = 5;
            this.btnSAC.Text = "S&AC";
            this.btnSAC.UseVisualStyleBackColor = true;
            // 
            // btnServicos
            // 
            this.btnServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.Location = new System.Drawing.Point(290, 269);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(209, 190);
            this.btnServicos.TabIndex = 4;
            this.btnServicos.Text = "&Serviços";
            this.btnServicos.UseVisualStyleBackColor = true;
            // 
            // btnContatos
            // 
            this.btnContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContatos.Location = new System.Drawing.Point(37, 269);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(209, 190);
            this.btnContatos.TabIndex = 3;
            this.btnContatos.Text = "Con&tatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(584, 492);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(165, 45);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSAC);
            this.Controls.Add(this.btnServicos);
            this.Controls.Add(this.btnContatos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.btnChamados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile-Services";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChamados;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnSAC;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnVoltar;
    }
}