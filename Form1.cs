using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class JoKenPo : Form
    {
        public JoKenPo()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void StartGame(int opcao)
        {
            lblResult.Visible = false;
            Game jogo = new Game();

            switch (jogo.Jogar(opcao)) 
            {
                case Game.Resultado.Ganhar:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Ganhar.png");
                    goto default;
                case Game.Resultado.Perder:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Perder.png");
                    goto default;
                case Game.Resultado.Empatar:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Empatar.png");
                    goto default;
                default:
                    pictureBox1.Image = jogo.ImgPlayer;
                    pictureBox2.Image = jogo.ImgPC;
                    break;

            }

        }
    }
}
