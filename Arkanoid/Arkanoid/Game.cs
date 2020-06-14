using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Game : UserControl
    {
          private CustomPictureBox[,] cpb;
          private PictureBox ball;
          
            private delegate void BallAction();
            private readonly BallAction BallMovement;
            public Action GameOver;

                
        public Game()
        {
            InitializeComponent();
               BallMovement = JumpingBall;
               BallMovement += MoveBall;
        }
        
       
                private void ControlArkanoid_Load(object sender, EventArgs e)
                {
                    
                    pictureBox1.BackgroundImage = Image.FromFile("../../img/Player.png");
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        
                    pictureBox1.Top = Height - pictureBox1.Height - 80;
                    pictureBox1.Left = (Width / 2) - (pictureBox1.Width / 2);
        
                    
                    ball = new PictureBox();
                    ball.Width = ball.Height = 20;
                    ball.BackgroundImage = Image.FromFile("../../img/ball.png");
                    ball.BackgroundImageLayout = ImageLayout.Stretch;
        
                    ball.Top = pictureBox1.Top - ball.Height;
                    ball.Left = pictureBox1.Left + (pictureBox1.Width / 2) - (ball.Width / 2);
        
                    Controls.Add(ball);
        
                    LoadTiles();
                    timer1.Start();
                }
        
                private void LoadTiles()
                {
                    int x = 10, y = 5;
        
                    int pbWidth = (Width - (x - 5)) / x;
                    int pbHeight = (int)(Height * 0.3) / y;
        
                    cpb = new CustomPictureBox[y, x];
        
                    for (int i = 0; i < y; i++)
                    {
                        for (int j = 0; j < x; j++)
                        {
                            cpb[i, j] = new CustomPictureBox();
        
                            if (i == 0)
                                cpb[i, j].strikes = 2;
                            else
                                cpb[i, j].strikes = 1;
        
                            cpb[i, j].Height = pbHeight;
                            cpb[i, j].Width = pbWidth;
        
                            
                            cpb[i, j].Left = j * pbWidth;
                            cpb[i, j].Top = i * pbHeight;
        
                            cpb[i, j].BackgroundImage = Image.FromFile("../../img/" + GenerateTiles() + ".png");
                            cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
        
                            cpb[i, j].Tag = "tileTag";
        
                            Controls.Add(cpb[i, j]);
                        }
                    }
                }
        
                private int GenerateTiles()
                {
                    return new Random().Next(1, 9);
                }
        
                private void ControlArkanoid_MouseMove(object sender, MouseEventArgs e)
                {
                    if (!DataGame.StartGame)
                    {
                        if (e.X < (Width - pictureBox1.Width))
                        {
                            pictureBox1.Left = e.X;
                            ball.Left = pictureBox1.Left + (pictureBox1.Width / 2) - (ball.Width / 2);
                        }
                    }
                    else
                    {
                        if (e.X < (Width - pictureBox1.Width))
                            pictureBox1.Left = e.X;
                    }
                }
        
                private void Timer1_Tick(object sender, EventArgs e)
                {
                    if (!DataGame.StartGame)
                        return;
        
                    BallMovement?.Invoke();
                }
        
                private void ControlArkanoid_KeyDown(object sender, KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Space)
                        DataGame.StartGame = true;
                }
        
                private void JumpingBall()
                {
                    if (ball.Bottom > Height)
                    {
                        timer1.Stop();
                        GameOver?.Invoke();
                    }
        
                    if (ball.Left < 0 || ball.Right > Width)
                    {
                        DataGame.X = -DataGame.X;
                        return;
                    }
        
                    if (ball.Bounds.IntersectsWith(pictureBox1.Bounds))
                    {
                        DataGame.Y = -DataGame.Y;
                    }
        
                    for (int i = 4; i >= 0; i--)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (cpb[i, j] != null && ball.Bounds.IntersectsWith(cpb[i, j].Bounds))
                            {
                                cpb[i, j].strikes--;
        
                                if (cpb[i, j].strikes == 0)
                                {
                                    Controls.Remove(cpb[i, j]);
                                    cpb[i, j] = null;
                                }
                                DataGame.Y = -DataGame.Y;
        
                                return;
                            }
                        }
                    }
                }
        
                private void MoveBall()
                {
                    ball.Left += DataGame.X;
                    ball.Top += DataGame.Y;
                }
    }
}
                
              