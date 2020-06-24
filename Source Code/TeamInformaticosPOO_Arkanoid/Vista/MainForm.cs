using System;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Controlador;
using Arkanoid.Modelo;

namespace Arkanoid.Vista
{
    public partial class Form1 : Form
    {
        // UserControl del juego
        private ControlArkanoid ctrl_Arkanoid;
        private Player Current_Player;
        
        public Form1()
        {
            InitializeComponent();
            
            // Maximizar ventana en su creacion
            
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }

        
        private void BttnStartGame_Click(object sender, EventArgs e)
        {
            
            
            GameData.InitializeGame();
            // Instanciacion y preparacion de UserControl
            ctrl_Arkanoid = new ControlArkanoid
            {
                Dock = DockStyle.Fill,

                Width = Width,
                Height = Height
            };

            // Seteo de Delegate que maneja el fin del juego
            ctrl_Arkanoid.FinishGame = () =>
            {
                MessageBox.Show("Game over!");

                ctrl_Arkanoid.Hide();
                tableLayoutPanel1.Show();
            };

            // Seteo de Delegate que maneja cuando se gana el juego
            ctrl_Arkanoid.WinningGame = () =>
            {
                PlayerController.CreateNewScore(Current_Player.idPlayer, GameData.score);

                MessageBox.Show("Felicidades has ganado!");

                ctrl_Arkanoid.Hide();
                tableLayoutPanel1.Show();
            };

            tableLayoutPanel1.Hide();

            Register fr = new Register();

            fr.get_nickname = (string nickName) => 
            {
                if (PlayerController.CreatePlayer(nickName))
                {
                    MessageBox.Show($"Bienvenido, ya te habias registrado {nickName}");
                }
                else
                {
                    MessageBox.Show($"Se ha resgistrado a: {nickName}");
                }

                Current_Player = new Player(nickName, 0);

                fr.Dispose();
            };

            fr.Show();

            Controls.Add(ctrl_Arkanoid);
        }

        private void BttnViewTop_Click(object sender, EventArgs e)
        {
            TopPlayers ft = new TopPlayers
            {
                CloseAction = () =>
                {
                    Show();
                }
            };

            ft.Show();
            
        }

        private void BttnExitApplication_Click(object sender, EventArgs e)
        {



            if (MessageBox.Show("Estas seguro que deseas salir?", "Saliendo..."
                , MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Seteo de atributos iniciales 
            tableLayoutPanel1.BackColor = Color.Transparent;

            BackgroundImage = Image.FromFile("../../Img/fondo_arkanoid.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
    
}
