using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gasolina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipo = cboxtipo.Text;
            double quantidade = Convert.ToDouble(tbxquantidade.Text);
            if(tipo == "gasolina" && quantidade <= 20)
            {
                lbldesconto.Text = ("O valor total ficará: R$" + (quantidade * 5) * 0.96);
                MessageBox.Show("Você tem 4% de desconto por litro", "descontos");
                pboximg.ImageLocation = "../../../offer.png";
            }
            if(tipo == "gasolina" && quantidade > 20)
            {
                lbldesconto.Text = ("O valor total ficará: R$" + (quantidade * 5) * 0.94);
                MessageBox.Show("Você tem 6% de desconto por litro", "descontos");
                pboximg.ImageLocation = "../../../offer.png";
            }
            if (tipo == "alcool" && quantidade <= 20)
            {
                lbldesconto.Text = ("O valor total ficará: R$" + (quantidade * 5.5) * 0.96);
                MessageBox.Show("Você tem 4% de desconto por litro", "descontos");
                pboximg.ImageLocation = "../../../offer.png";
            }
            if (tipo == "alcool" && quantidade > 20)
            {
                lbldesconto.Text = ("O valor total ficará: R$" + (quantidade * 5.5) * 0.94);
                MessageBox.Show("Você tem 6% de desconto por litro", "descontos");
                pboximg.ImageLocation = "../../../offer.png";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
