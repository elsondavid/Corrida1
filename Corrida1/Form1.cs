using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corrida1
{
    public partial class Form1 : Form
    {
        private Guy[] apostadores { get; set; }
        private Greyhound[] caes { get; set; }
        public Form1()
        {
            InitializeComponent();

            int tamanhoPista = picPista.Size.Width;

            apostadores = new Guy[3];
            apostadores[0] = new Guy();
            apostadores[0].Name = "João";
            apostadores[0].Cash = 50;
            apostadores[0].MyLabel = lblApostaJoao;
            apostadores[0].MyRadioButon = rbtJoao;

            apostadores[1] = new Guy();
            apostadores[1].Name = "Beto";
            apostadores[1].Cash = 75;
            apostadores[1].MyLabel = lblApostaBeto;
            apostadores[1].MyRadioButon = rbtBeto;

            apostadores[2] = new Guy();
            apostadores[2].Name = "Alfredo";
            apostadores[2].Cash = 45;
            apostadores[2].MyLabel = lblApostaAlfredo;
            apostadores[2].MyRadioButon = rbtAlfredo;

            caes = new Greyhound[4];
            caes[0] = new Greyhound();
            caes[0].Numero = 1;
            caes[0].RacetrackLength = tamanhoPista;
            caes[0].MyPictureBox = pic1;

            caes[1] = new Greyhound();
            caes[1].Numero = 2;
            caes[1].RacetrackLength = tamanhoPista;
            caes[1].MyPictureBox = pic2;

            caes[2] = new Greyhound();
            caes[2].Numero = 3;
            caes[2].RacetrackLength = tamanhoPista;
            caes[2].MyPictureBox = pic3;

            caes[3] = new Greyhound();
            caes[3].Numero = 4;
            caes[3].RacetrackLength = tamanhoPista;
            caes[3].MyPictureBox = pic4;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Guy apostador in apostadores)
            {
                apostador.UpdateLabels();
            }

            lblApostaMinima.Text = ((int)numValor.Minimum).ToString();
        }

        private void btnCorram_Click_1(object sender, EventArgs e)
        {
            // Desabilita todos os controles do Form
            this.Enabled = false;

            // Faz os cachorros andarem na pista, até terminarem o
            // circuito e haver um vencedor.
            int vencedor = Correr();

            foreach (Guy apostador in apostadores)
            {
                // Pagar de acordo com o vencedor
                apostador.Collect(vencedor);

                // Limpa a aposta realizada
                apostador.ClearBet();

                // Atualizar os rótulos
                apostador.UpdateLabels();
            }

            foreach (Greyhound cao in caes)
            {
                cao.TakeStartingPosition();
            }

            MessageBox.Show(string.Format("O cão número {0} venceu a corrida!", vencedor), "Fim de corrida", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Habilita todos os controles do Form
            this.Enabled = true;
        }

        private int Correr()
        {
            int vencedor = 0;
            while (vencedor == 0)
            {
                foreach (Greyhound cao in caes)
                {
                    bool ehVencedor = cao.Run();

                    if (ehVencedor)
                    {
                        vencedor = cao.Numero;
                    }
                    Thread.Sleep(50);
                }
                Application.DoEvents();
            }

            return vencedor;
        }

        private void btnAposta_Click(object sender, EventArgs e)
        {

            foreach (Guy apostador in apostadores)
            {
                if (apostador.Name == lblApostaNome.Text)
                {
                    if (apostador.PlaceBet((int)numValor.Value, (int)numCachorro.Value))
                    {
                        apostador.UpdateLabels();
                    }
                    else
                    {
                        MessageBox.Show("Não há saldo suficiente para esta aposta!", "Seu trouxa!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }


        private void rbt_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Guy apostador in apostadores)
            {
                if ((RadioButton)sender == apostador.MyRadioButon)
                {
                    lblApostaNome.Text = apostador.Name;
                    break;
                }
            }
        }

    }
}
