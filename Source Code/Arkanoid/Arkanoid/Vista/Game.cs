using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Game : UserControl
    {
        private Panel Scores;
        private Label  score;
        private Game game;
        private CustomPictureBox[,] cpb;
        private PictureBox ball;

        //picture box + label
        private PictureBox heart;
        
        // para trabajar n picture box;
        private PictureBox[] lifes;

        private delegate void BallAction();

        private readonly BallAction BallMovement;
        public Action FinishedGame, WinningGame;
        
        public Game()
        {
            InitializeComponent();
            BallMovement = JumpingBall;
            BallMovement += MoveBall;

        }
        
       
        //Para quitar el problema del fondo
        protected override CreateParams CreateParams
                {
                    get
                    {
                        CreateParams handleParam = base.CreateParams;
                        handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                        return handleParam;
                    }
                }
       

        private void ControlArkanoid_Load(object sender, EventArgs e)
        {
            PanelScore();

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
        }

      

        private int GenerateBlnded()
        {
            return new Random().Next(12, 13);
        }

        private int GenerateTiles()
        {
            return new Random().Next(1, 8);
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
         private void LoadTiles()
        {
            int x = 10, y = 5;

            int pbWidth = (Width - (x - 5)) / x;
            int pbHeight = (int) (Height * 0.3) / y;

            cpb = new CustomPictureBox[y, x];

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    cpb[i, j] = new CustomPictureBox();
                        //  no se como seria
                        // y ase ocmo pero umm esta complciado  yo no entiendo jaja
                         
                    //:"v

                    if ((i == 4||i==0)&(j%2==0))
                    {
                        cpb[i, j].Hits = 2;
                    }
                    else if (i==2)
                    {
                        cpb[i, j].Hits = 2;
                    }
                    else
                        cpb[i, j].Hits = 1;

                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;


                    cpb[i, j].Left = j * pbWidth;
                    cpb[i, j].Top = i * pbHeight + Scores.Height + 1;

                    int imageback = 0;

                    if (i % 2 == 0 && j % 2 == 0)
                        imageback = 3;
                    else if (i % 2 == 0 && j % 2 != 0)
                        imageback = 4;
                    else if (i % 2 != 0 && j % 2 == 0)
                        imageback = 4;
                    else
                        imageback = 3;
                    
                   
                    if ((i == 4||i==0)&(j%2==0))
                    {
                        cpb[i, j].BackgroundImage = Image.FromFile("../../tiles/13.png");
                        cpb[i, j].Tag = "blindedBlue";
                        
                    }
                    else if (i==2)
                    {
                        cpb[i, j].BackgroundImage = Image.FromFile("../../tiles/12.png");
                        cpb[i, j].Tag = "blinded";
                    }
                    else
                    {
                        cpb[i, j].BackgroundImage = Image.FromFile("../../tiles/" + GenerateTiles() + ".png");
                        cpb[i, j].Tag = "tileTag";

                    }

                    cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;

                    Controls.Add(cpb[i, j]);
                }
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!DataGame.StartGame)
                return;
            DataGame.MadeTicks += 0.01;
            BallMovement?.Invoke();
        }

        private void ControlArkanoid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                DataGame.StartGame = true;
                timer1.Start();
            }

               
        }

        private void JumpingBall()
        {
            if (ball.Top < 0)
            {
                DataGame.Y = -DataGame.Y;

            }
            
            
            if (ball.Bottom > Height)
            {
                DataGame.lifes--;
                DataGame.StartGame = false;
                timer1.Stop();

                RepositionElements();
                UpdateItems();

                if (DataGame.lifes==0)
                {
                    timer1.Stop();
                    FinishedGame?.Invoke();
                  
                }
                
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
                        
                        DataGame.scoreGame += (int) (cpb[i, j].Hits * DataGame.MadeTicks);
                        cpb[i, j].Hits--;
                        
                            
                            if (cpb[i, j].Hits == 0)
                        {
                            Controls.Remove(cpb[i, j]);
                            cpb[i, j] = null;
                        }
                        else if (cpb[i, j].Tag.Equals("blinded"))
                            {
                                cpb[i, j].BackgroundImage = Image.FromFile("../../tiles/brk.png");
                               
                            }
                            else if (cpb[i, j].Tag.Equals("blindedBlue"))
                            {
                                cpb[i, j].BackgroundImage = Image.FromFile("../../tiles/brk2.png");
                            }
                            

                        DataGame.Y = -DataGame.Y;

                        score.Text = DataGame.scoreGame.ToString();
            
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
    
        public void PanelScore()
        {
            Scores = new Panel();
            Scores.Width = Width;
            Scores.Height = (int)(Height*0.07);

            Scores.Top = Scores.Left = 0;
            Scores.BackColor = Color.Black;
            
            //n cantidad de picture box
            
            lifes = new PictureBox[DataGame.lifes];
            
            for (int i = 0; i < DataGame.lifes; i++)
            {
                lifes[i]= new PictureBox();

                lifes[i].Height  = lifes[i].Width = Scores.Height;
                
                lifes[i].BackgroundImage = Image.FromFile("../../img/Heart.png");
                lifes[i].BackgroundImageLayout = ImageLayout.Stretch;

                lifes[i].Top = 0;

                if (i == 0)
                {
                    lifes[i].Left = 20;
                }
                else
                {
                    lifes[i].Left = lifes[i - 1].Right + 5;
                }
            }
            
            score = new Label();
  
            score.ForeColor = Color.White;
            
            score.Text = "Score" + DataGame.scoreGame.ToString();
            
            score.Font =new Font("Century", 24f);
            score.Left = Width - 200;

            score.Height = Scores.Height;
            score.TextAlign = ContentAlignment.MiddleCenter;
 
            //Scores.Controls.Add(VidasRestantes);
            Scores.Controls.Add(score);

            foreach (var pb in lifes)
            {
               Scores.Controls.Add(pb);
            }
            
            Controls.Add(Scores);
        }

        private void RepositionElements()
        {
            pictureBox1.Left = (Width / 2) - (pictureBox1.Width / 2);
            ball.Top = pictureBox1.Top - ball.Height;
            ball.Left = pictureBox1.Left + (pictureBox1.Width / 2) - (ball.Width / 2);
            
        }

        private void UpdateItems()
        {
            Scores.Controls.Remove(lifes[DataGame.lifes]);
            lifes[DataGame.lifes] = null;
        }
        
}
}