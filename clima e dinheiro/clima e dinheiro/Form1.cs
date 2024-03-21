using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clima_e_dinheiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            string clima = cbclima.Text;
            double dinheiro = Convert.ToDouble(tbxdinheiro.Text);
            if (clima == "sol" && dinheiro >= 500) 
            {
                MessageBox.Show("praia","Você pode ir para:");
                pbclima.ImageLocation = "../../../praia.jpg";
            }
            if (clima == "sol" && dinheiro < 500) 
            {
                MessageBox.Show("um sorvete","Você pode ir tomar:");
                pbclima.ImageLocation = "../../../sorvete.png";
            }
            if (clima == "chuva" && dinheiro >= 500) 
            {
                MessageBox.Show("serra","Você pode ir para:");
                pbclima.ImageLocation = "../../../serra.jpg";
            }
            if (clima == "chuva" && dinheiro < 500)
            {
                MessageBox.Show("um chocolate quente","Você pode ir tomar:");
                pbclima.ImageLocation = "../../../chocolate.jpg";
            }
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
