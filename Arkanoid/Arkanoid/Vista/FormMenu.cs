using System;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Controlador;
using Arkanoid.Modelo;
using Arkanoid.Vista;

namespace Arkanoid
{
    public partial class FormMenu : Form
    {
        private Game game;
        private Top10 top;
        private Player current;
        private Register register;
        private UserControl uc;

        public FormMenu()
        {
     
            InitializeComponent();
            
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
              
             }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            uc = new Register();
            
             uc.Dock = DockStyle.Fill;
             uc.Width = Width;
             uc.Height = Height;
             
             tableLayoutPanel1.Hide();
  
             Controls.Add(register);
            
             register.nick = (string nickname) =>
             {
                 if (PlayerData.CreatePlayer(nickname))
                 {
                     MessageBox.Show($"Bienvenido {nickname}");
                 }
                 else
                 {

                     MessageBox.Show($"Se ha registrado correctamente {nickname}");
                 }
                 current = new Player(nickname, 0);
                 
                 
                 return null;

             };
             register.Hide();
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
            //Instanciando los user control
            game = new Game();
            top = new  Top10();
        
            game.Dock  = DockStyle.Fill;

            game.Width = Width;
            game.Height = Height;

            //seteando medidas top
            top.Width = Width;
            game.Height = Height;

            top.Dock = DockStyle.Fill;

            game.FinishedGame = () =>
                 {
                   game = null;
                   game = new Game();
            
                   MessageBox.Show("Has perdido");
               
                    game.Hide();
                    tableLayoutPanel1.Show();
                        };
             
            //Agregando el user del top 10
             top.Dock = DockStyle.Fill;
             
            top.Width = Width;
            top.Height = Height;
            
        }

        private void BtnTop10Click(object sender, EventArgs e){
            tableLayoutPanel1.Hide();
          Controls.Add(top);

        }
    }
}
           