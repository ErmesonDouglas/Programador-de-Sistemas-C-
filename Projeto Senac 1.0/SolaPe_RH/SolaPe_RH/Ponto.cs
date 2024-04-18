using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolaPe_RH
{
    public partial class Ponto : Form
    {
        public Ponto()
        {
            InitializeComponent();
            var pos = label1.Parent.PointToScreen(label1.Location);
            pos = pictureBox1.PointToClient(pos);
            label1.Parent = pictureBox1;
            label1.Location = pos;
            label1.BackColor = Color.Transparent;

            pos = label2.Parent.PointToScreen(label2.Location);
            pos = pictureBox1.PointToClient(pos);
            label2.Parent = pictureBox1;
            label2.Location = pos;
            label2.BackColor = Color.Transparent;

            pos = label4.Parent.PointToScreen(label4.Location);
            pos = pictureBox1.PointToClient(pos);
            label4.Parent = pictureBox1;
            label4.Location = pos;
            label4.BackColor = Color.Transparent;

            btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCalcular.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCalcular.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {           
                // Get the start and end times from the TextBox controls
                TimeSpan startTime = TimeSpan.Parse(tbxEntrada.Text);
                TimeSpan endTime = TimeSpan.Parse(tbxSaida.Text);

                // Calculate the total time worked
                TimeSpan totalTime = endTime - startTime;

                // Display the total time worked in the Label control
                lblHoras.Text = totalTime.ToString();
        }
    }
}
