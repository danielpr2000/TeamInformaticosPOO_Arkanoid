using Arkanoid.Controlador;
using Arkanoid.Modelo;
using Arkanoid.Vista;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        // UserControl del juego
        private ControlArkanoid ca;
        private Player currentPlayer;
        
        public Form1()
        {
            InitializeComponent();
            
            // Maximizar ventana en su creacion
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Seteo de atributos iniciales 
            tableLayoutPanel1.BackColor = Color.Transparent;

            BackgroundImage = Image.FromFile("../../Img/bg.png");
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void BttnStartGame_Click(object sender, EventArgs e)
        {
            GameData.InitializeGame();
            // Instanciacion y preparacion de UserControl
            ca = new ControlArkanoid
            {
                Dock = DockStyle.Fill,

                Width = Width,
                Height = Height
            };

            // Seteo de Delegate que maneja el fin del juego
            ca.FinishGame = () =>
            {
                MessageBox.Show("Has perdido");

                ca.Hide();
                tableLayoutPanel1.Show();
            };

            // Seteo de Delegate que maneja cuando se gana el juego
            ca.WinningGame = () =>
            {
                PlayerController.CreateNewScore(currentPlayer.idPlayer, GameData.score);

                MessageBox.Show("Has ganado!");

                ca.Hide();
                tableLayoutPanel1.Show();
            };

            tableLayoutPanel1.Hide();

            FormRegister fr = new FormRegister();

            fr.gn = (string nick) => 
            {
                if (PlayerController.CreatePlayer(nick))
                {
                    MessageBox.Show($"Bienvenido nuevamenete {nick}");
                }
                else
                {
                    MessageBox.Show($"Gracias por registrarte {nick}");
                }

                currentPlayer = new Player(nick, 0);

                fr.Dispose();
            };

            fr.Show();

            Controls.Add(ca);
        }

        private void BttnViewTop_Click(object sender, EventArgs e)
        {
            FormTop ft = new FormTop
            {
                CloseAction = () =>
                {
                    Show();
                }
            };

            ft.Show();
            Hide();
        }

        private void BttnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
