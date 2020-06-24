using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class FormMenu : Form
    {
        private Game game;
        private Top10 top;
        private Player current;

        public FormMenu()
        {

            InitializeComponent();

            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            game = new Game()
            {
                Dock = DockStyle.Fill,

                Width = Width,
                Height = Height
            };
            DataGame.InitializeGame();
            game.FinishedGame = () =>
            {
                MessageBox.Show("Has perdido");

                game.Hide();
                tableLayoutPanel1.Show();
            };

            // Seteo de Delegate que maneja cuando se gana el juego
            game.WinningGame = () =>
            {
                PlayerData.NewScore(current.IdPlayer, DataGame.scoreGame);

                MessageBox.Show("Has ganado!");

                game.Hide();
                tableLayoutPanel1.Show();
            };

            tableLayoutPanel1.Hide();

            FRegister fr = new FRegister();

            fr.gn = (string nick) =>
            {
                if (PlayerData.CreatePlayer(nick))
                {
                    MessageBox.Show($"Bienvenido nuevamenete {nick}");
                }
                else
                {
                    MessageBox.Show($"Gracias por registrarte {nick}");
                }

                current = new Player(nick, 0);

                fr.Dispose();
            };

            fr.Show();

            Controls.Add(game);
        }
            
        
    

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Salir",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Instanciando los user control
            game = new Game();
            top = new Top10();

            game.Dock = DockStyle.Fill;

            game.Width = Width;
            game.Height = Height;

        }




        private void BtnTop10Click(object sender, EventArgs e){
            tableLayoutPanel1.Hide();
          Controls.Add(top);

        }
    }
}
           