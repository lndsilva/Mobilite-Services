using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mobilitec_Services
{
    public partial class frmCarregaFoto : Form
    {
        public frmCarregaFoto()
        {
            InitializeComponent();
        }

        private void btnAdicionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarIMG = new OpenFileDialog();
            BuscarIMG.InitialDirectory = ("d:\\imagens\\");
            BuscarIMG.FileName = "Imagem";
            BuscarIMG.Title = "Procurar Imagem";
            BuscarIMG.Filter = ("*jpg|*.jpg|*png|*.png|*bmp|*.bmp|*tif|*.tif");
            BuscarIMG.ShowDialog();
            pcbFoto.ImageLocation = (BuscarIMG.FileName);
        }

        private void btnExcluirFoto_Click(object sender, EventArgs e)
        {
            pcbFoto.Image = null;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "INSERT INTO TbImagens(imagem) VALUES ('@imagem');";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@imagem", MySqlDbType.LongBlob).Value = pcbFoto.Image;

            comm.Connection = Conexao.obterConexao();

            int i = comm.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso!!!" + i);

            Conexao.fecharConexao();
        }

        private void btnPesquisaFoto_Click(object sender, EventArgs e)
        {
            cbbPesquisaFoto.Items.Clear();

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codImg from TbImagens;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbbPesquisaFoto.Items.Add(DR.GetInt32(0));
            }

            Conexao.fecharConexao();
        }

        private void cbbPesquisaFoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selecao = Convert.ToInt32(cbbPesquisaFoto.SelectedItem.ToString());
            //buscaFoto(selecao);
        }

        public void carregaFoto()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT imagem from tbimagens";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();

            if (DR.Read())
            {
                string imagem = Convert.ToString(DateTime.Now.ToFileTime());
                byte[] bimage = (byte[])DR["imagem"];
                FileStream fs = new FileStream(imagem, FileMode.CreateNew, FileAccess.Write);
                fs.Write(bimage, 0, bimage.Length - 1);
                fs.Close();
                pcbFoto.Image = Image.FromFile(imagem);
            }
            Conexao.fecharConexao();              



        }



        //public void buscaFoto(int codFoto)
        //{
        //    MySqlCommand comm = new MySqlCommand();
        //    comm.CommandText = "SELECT imagem from tbimagens WHERE codImg = " + codFoto + ";";
        //    comm.CommandType = CommandType.Text;

        //    comm.Connection = Conexao.obterConexao();

        //    MySqlDataReader DR;

        //    DR = comm.ExecuteReader();

        //    DR.Read();

        //    byte[] byteBlobData = (byte[])DR["imagem"];
        //    pcbFoto.Image = ToImage(byteBlobData);           

        //    Conexao.fecharConexao();

        //}
        //public static Image ToImage(byte[] data)
        //{
        //if (data == null)
        //{
        //    return null;
        //}

        //Image img;
        //MemoryStream stream = new MemoryStream(data);
        //{
        //    Image temp = Image.FromStream(stream);

        //    img = new Bitmap(temp);
        //
        //    return img;
        //}}

        private void btnCarregaDGV_Click(object sender, EventArgs e)
        {
            carregaFoto();
        }
    }
}
