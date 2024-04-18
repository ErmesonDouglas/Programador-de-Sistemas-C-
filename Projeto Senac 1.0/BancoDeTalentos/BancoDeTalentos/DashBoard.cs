using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeTalentos
{
    public partial class DashBoard : Form
    {
        public DashBoard(string usuario)
        {
            InitializeComponent();
            lblMsg.Text = "Seja Bem Vindo! " + usuario;
            Cadastro c = new Cadastro();
            c.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
