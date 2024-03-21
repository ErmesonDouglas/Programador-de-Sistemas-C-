using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sangue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbxidade_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
           
            int idade = Convert.ToInt32(tbxidade.Text);
            
            if (idade >= 18 && idade <= 67) 
            {
                MessageBox.Show(tbxnome.Text + ", Você pode doar sangue","HEMOCE");
            }
            else
            {
                MessageBox.Show(tbxnome.Text + ", Você não pode doar sangue", "HEMOCE");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
