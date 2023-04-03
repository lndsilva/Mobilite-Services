
namespace Mobilitec_Services
{
    partial class frmCarregaFoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarregaFoto));
            this.btnExcluirFoto = new System.Windows.Forms.Button();
            this.btnAdicionarFoto = new System.Windows.Forms.Button();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.lblFotoFunc = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnPesquisaFoto = new System.Windows.Forms.Button();
            this.cbbPesquisaFoto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluirFoto
            // 
            this.btnExcluirFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirFoto.Image")));
            this.btnExcluirFoto.Location = new System.Drawing.Point(295, 180);
            this.btnExcluirFoto.Name = "btnExcluirFoto";
            this.btnExcluirFoto.Size = new System.Drawing.Size(109, 61);
            this.btnExcluirFoto.TabIndex = 22;
            this.btnExcluirFoto.Tag = "Excluir foto funcionário";
            this.btnExcluirFoto.Text = "Excluir Foto";
            this.btnExcluirFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirFoto.UseVisualStyleBackColor = true;
            this.btnExcluirFoto.Click += new System.EventHandler(this.btnExcluirFoto_Click);
            // 
            // btnAdicionarFoto
            // 
            this.btnAdicionarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarFoto.Image")));
            this.btnAdicionarFoto.Location = new System.Drawing.Point(295, 73);
            this.btnAdicionarFoto.Name = "btnAdicionarFoto";
            this.btnAdicionarFoto.Size = new System.Drawing.Size(109, 61);
            this.btnAdicionarFoto.TabIndex = 21;
            this.btnAdicionarFoto.Tag = "Adicionar foto funcionário";
            this.btnAdicionarFoto.Text = "Carregar Foto";
            this.btnAdicionarFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionarFoto.UseVisualStyleBackColor = true;
            this.btnAdicionarFoto.Click += new System.EventHandler(this.btnAdicionarFoto_Click);
            // 
            // pcbFoto
            // 
            this.pcbFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcbFoto.Location = new System.Drawing.Point(68, 73);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(208, 168);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 24;
            this.pcbFoto.TabStop = false;
            // 
            // lblFotoFunc
            // 
            this.lblFotoFunc.AutoSize = true;
            this.lblFotoFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFotoFunc.Location = new System.Drawing.Point(74, 27);
            this.lblFotoFunc.Name = "lblFotoFunc";
            this.lblFotoFunc.Size = new System.Drawing.Size(132, 24);
            this.lblFotoFunc.TabIndex = 23;
            this.lblFotoFunc.Text = "Carrega Foto";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(68, 286);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(109, 61);
            this.btnCadastrar.TabIndex = 25;
            this.btnCadastrar.Tag = "";
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnPesquisaFoto
            // 
            this.btnPesquisaFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisaFoto.Image")));
            this.btnPesquisaFoto.Location = new System.Drawing.Point(551, 180);
            this.btnPesquisaFoto.Name = "btnPesquisaFoto";
            this.btnPesquisaFoto.Size = new System.Drawing.Size(109, 61);
            this.btnPesquisaFoto.TabIndex = 26;
            this.btnPesquisaFoto.Tag = "";
            this.btnPesquisaFoto.Text = "Pesquisar";
            this.btnPesquisaFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisaFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisaFoto.UseVisualStyleBackColor = true;
            this.btnPesquisaFoto.Click += new System.EventHandler(this.btnPesquisaFoto_Click);
            // 
            // cbbPesquisaFoto
            // 
            this.cbbPesquisaFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPesquisaFoto.FormattingEnabled = true;
            this.cbbPesquisaFoto.Location = new System.Drawing.Point(551, 110);
            this.cbbPesquisaFoto.Name = "cbbPesquisaFoto";
            this.cbbPesquisaFoto.Size = new System.Drawing.Size(110, 24);
            this.cbbPesquisaFoto.TabIndex = 27;
            this.cbbPesquisaFoto.SelectedIndexChanged += new System.EventHandler(this.cbbPesquisaFoto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Código da Foto";
            // 
            // frmCarregaFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbPesquisaFoto);
            this.Controls.Add(this.btnPesquisaFoto);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnExcluirFoto);
            this.Controls.Add(this.btnAdicionarFoto);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.lblFotoFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCarregaFoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrega Foto";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirFoto;
        private System.Windows.Forms.Button btnAdicionarFoto;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Label lblFotoFunc;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnPesquisaFoto;
        private System.Windows.Forms.ComboBox cbbPesquisaFoto;
        private System.Windows.Forms.Label label1;
    }
}