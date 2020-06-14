using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        private Game game;

        public Form1()
        {
     
            InitializeComponent();
            
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
              
             }

        private void BtnStart_Click(object sender, EventArgs e)
        {
             tableLayoutPanel1.Hide();
             Controls.Add(game);
 }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Salir", 
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            
            if(result == DialogResult.Yes)
                Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game();
            
            game.Dock  = DockStyle.Fill;

            game.Width = Width;
            game.Height = Height;
            
             game.GameOver = () =>
                 {
                   game = null;
                   game = new Game();
            
                   MessageBox.Show("Has perdido");
               
                    game.Hide();
                    tableLayoutPanel1.Show();
                        };

        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En proceso");
        }
    }
}
           