using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//comentário de linha

namespace Mobilitec_Services
{
    //isso é uma classe do sistema
    public partial class frmLogin : Form
    {
        //comentário de linha
        public frmLogin()
        {
            InitializeComponent();
        }
        /*
         * autor:
         * data:
         * comentário de bloco
         * 
         * */

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }      

        
    }
}