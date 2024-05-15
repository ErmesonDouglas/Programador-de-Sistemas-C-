using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpgSenac
{
    public partial class Form1 : Form
    {
        private Jogador j1;
        private Jogador j2;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            j1 = new Jogador(1, 10, 5, 3);
            lblAtaqueJ1.Text = j1.getAtaqueP().ToString();
            lblDefesaJ1.Text = j1.getDefesaP().ToString();
            lblVidaJ1.Text   = j1.getVida().ToString();
            j2 = new Jogador(2, 6, 4, 4);
            lblAtaqueJ2.Text = j2.getAtaqueP().ToString();
            lblDefesaJ2.Text = j2.getDefesaP().ToString();
            lblVidaJ2.Text   = j2.getVida().ToString();

            lblDanoJ1.Text = "";
            lblDanoJ2.Text = "";

            pbxJ1.ImageLocation = "../../../j1padrao.png";
            pbxJ2.ImageLocation = "../../../j2padrao.png";

            //Turno J1
            TurnoJ1();

        }

        private void TurnoJ1()
        {
            if (seVivos())
            {
                //habilitar os botões de ataque e defesa do J1
                btnAtaqueJ1.Enabled = true;
                btnDefesaJ1.Enabled = true;
                
                //btnAtaqueJ2 e btnDefesaJ2 ficam desabilitados
                btnAtaqueJ2.Enabled = false;
                btnDefesaJ2.Enabled = false;
                
                //voltar ataque e defesa para o padrão
                j1.setDefesa(j1.getDefesaP());
                j1.setAtaque(j1.getAtaqueP());
                
                //voltar para a imagem padrão (Default)
                pbxJ1.ImageLocation = "../../../j1padrao.png";
            }
        }

        private void TurnoJ2()
        {
            if (seVivos())
            {
                //habilitar os botoes de atk e def do j2
                btnAtaqueJ2.Enabled = true;
                btnDefesaJ2.Enabled = true;

                //btnAtaqueJ1 e btnDefesaJ1 ficam desabilitados
                btnAtaqueJ1.Enabled = false;
                btnDefesaJ1.Enabled = false;

                //voltar atk e def para o padrão
                j2.setDefesa(j2.getDefesaP());
                j2.setAtaque(j2.getAtaqueP());

                //voltar para a imagem padrão (default)
                pbxJ2.ImageLocation = "../../../j2padrao.png";
            }
        }
        private bool seVivos()
        {
            if(j1.getVida() > 0 && j2.getVida() > 0)
            {
                return true;
            }
            else if(j1.getVida() <= 0) 
            {
                
                //this.BackgroundImage = Image.FromFile("../../../J2Wins.jpeg");
                ptbFinal.Visible = true;
                btnReiniciar.Visible = true;
                btnReiniciar.BringToFront();
                ptbFinal.ImageLocation = "../../../J2Wins.jpeg";
                return false; 
            }
            else
            {
                //this.BackgroundImage = Image.FromFile("../../../J1Wins.jpeg");
                ptbFinal.Visible = true;
                btnReiniciar.Visible = true;
                btnReiniciar.BringToFront();
                ptbFinal.ImageLocation = "../../../J1Wins.jpeg";
                return false;
            }
        }

        private void btnAtaqueJ1_Click(object sender, EventArgs e)
        {
            btnAtaqueJ1.Enabled = false;
            if(seVivos())
            {
                lblAtaqueJ1.Text = j1.Ataque().ToString();
                //trocar o sprite
                pbxJ1.ImageLocation = "../../../j1ataque.png";
                if (j1.getAtaque() > j2.getDefesa())
                {
                    int dano =  (j1.getAtaque() - j2.getDefesa());
                    j2.setVida(j2.getVida() - dano);
                    pbxJ2.ImageLocation = "../../../j2ferido.png";
                    if (j2.getVida() > 0)
                    {
                        lblVidaJ2.Text = j2.getVida().ToString();
                    }
                    else
                    {
                        lblVidaJ2.Text = "0";
                    }
                    lblDanoJ2.Text = "-"+dano.ToString();
                    //System.Threading.Thread.Sleep(2000);
                    Esperar(1000, 1);
                }
                else
                {
                    lblDanoJ2.Text = "MISS";TurnoJ2();
                }
                
            }
        } 

        private async void Esperar(int delay, int jogador)
        {
            await Task.Delay(delay);
            if(jogador == 1)
            {
                TurnoJ2();
            }
            else
            {
                TurnoJ1();
            }
            
        }

        private void btnDefesaJ1_Click(object sender, EventArgs e)
        {
            btnDefesaJ1.Enabled = false;
            if (seVivos())
            {
                lblDefesaJ1.Text = j1.Defesa().ToString();
                //trocar o sprite
                pbxJ1.ImageLocation = "../../../j1defesa.png";
                TurnoJ2();
            }
        }

        private void btnAtaqueJ2_Click(object sender, EventArgs e)
        {
            btnAtaqueJ2.Enabled = false;
            if (seVivos())
            {
                lblAtaqueJ1.Text = j2.Ataque().ToString();
                //trocar o sprite
                pbxJ2.ImageLocation = "../../../j2ataque.png";
                if (j2.getAtaque() > j1.getDefesa())
                {
                    int dano = (j2.getAtaque() - j1.getDefesa());
                    j1.setVida(j1.getVida() - dano);
                    pbxJ1.ImageLocation = "../../../j1ferido.png";
                    if (j1.getVida() > 0)
                    {
                        lblVidaJ1.Text = j1.getVida().ToString();
                    }
                    else
                    {
                        lblVidaJ1.Text = "0";
                    }
                    lblDanoJ1.Text = "-" + dano.ToString();
                    //System.Threading.Thread.Sleep(2000);
                    Esperar(1000, 2);
                }
                else
                {
                    lblDanoJ1.Text = "MISS"; TurnoJ1();
                }
            }
        }

        private void btnDefesaJ2_Click(object sender, EventArgs e)
        {
            btnDefesaJ2.Enabled = false;
            if (seVivos())
            {
                lblDefesaJ2.Text = j2.Defesa().ToString();
                //trocar o sprite
                pbxJ2.ImageLocation = "../../../j2defesa.png";
                TurnoJ1();
            }
        }
        private void btnReiniciar_Click_1(object sender, EventArgs e)
        {
            ptbFinal.Visible = false;
            btnReiniciar.Visible = false;
            this.Form1_Load(this, e);
        }
    }
}
