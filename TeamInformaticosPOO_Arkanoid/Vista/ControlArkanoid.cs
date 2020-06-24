using System;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Controlador;
using Arkanoid.Modelo;

namespace Arkanoid.Vista
{
    public partial class ControlArkanoid : UserControl
    {
        private CustomPictureBox[,] cpb;
        private Panel scorePanel, blackPanel;
        private Label remainingLifes, score;
        private PictureBox ball;

        private double tiempoTranscurido = 0, tiempoLimite = 4;
        private int remainingPb = 0;

        // Para trabajar con pic + label
        private PictureBox heart;

        // Para trabajar con n pic
        private PictureBox[] hearts;

        private delegate void BallActions();
        private readonly BallActions BallMovements;
        public Action FinishGame, WinningGame;

        public ControlArkanoid()
        {
            InitializeComponent();

            BallMovements = BounceBall;
            BallMovements += MoveBall;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        // Metodos que coinciden con el delegate de Event
        private void ControlArkanoid_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;

            ScoresPanel();
            
            // Seteando los atributos para picBox jugador
            playerPb.BackgroundImage = Image.FromFile("../../Img/Player.png");
            playerPb.BackgroundImageLayout = ImageLayout.Stretch;

            playerPb.Top = Height - playerPb.Height - 80;
            playerPb.Left = (Width / 2) - (playerPb.Width / 2);

            // Seteando los atributos para picBox pelota
            ball = new PictureBox();
            ball.Width = ball.Height = 20;

            ball.BackgroundImage = Image.FromFile("../../Img/Ball.png");
            ball.BackgroundImageLayout = ImageLayout.Stretch;

            ball.Top = playerPb.Top - ball.Height;
            ball.Left = playerPb.Left + (playerPb.Width / 2) - (ball.Width / 2);

            Controls.Add(ball);

            LoadTiles();
        }

        private void LoadTiles()
        {
            // Variables auxiliares para el calculo de tamano de cada cpb
            int xAxis = 10, yAxis = 5;
            remainingPb = xAxis * yAxis;

            int pbWidth = (Width - (xAxis - 5)) / xAxis;
            int pbHeight = (int)(Height * 0.3) / yAxis;

            cpb = new CustomPictureBox[yAxis, xAxis];

            // Rutina de instanciacion y agregacion al UserControl
            for (int i = 0; i < yAxis; i++)
            {
                for (int j = 0; j < xAxis; j++)
                {
                    cpb[i, j] = new CustomPictureBox();

                    if (i == 4)
                        cpb[i, j].Hits = 2;
                    else
                        cpb[i, j].Hits = 1;

                    // Seteando el tamano
                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;

                    // Posicion de left, y posicion de top
                    cpb[i, j].Left = j * pbWidth;
                    cpb[i, j].Top = i * pbHeight + scorePanel.Height + 1;

                    int imageBack;
                    if (i % 2 == 0 && j % 2 == 0)
                        imageBack = 3;
                    else if (i % 2 == 0 && j % 2 != 0)
                        imageBack = 4;
                    else if (i % 2 != 0 && j % 2 == 0)
                        imageBack = 4;
                    else
                        imageBack = 3;

                    if (i == 4)
                    {
                        cpb[i, j].BackgroundImage = Image.FromFile("../../Img/tb1.png");
                        cpb[i, j].Tag = "blinded";
                    }
                    else
                    {
                        cpb[i, j].BackgroundImage = Image.FromFile("../../Img/" + imageBack  + ".png");
                        cpb[i, j].Tag = "tileTag";
                    }

                    cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;

                    Controls.Add(cpb[i, j]);
                }
            }
        }

        private void ControlArkanoid_MouseMove(object sender, MouseEventArgs e)
        {
            // Manejo de movimiento de barra y pelota cuando el juego no ha iniciado
            if (!GameData.gameStarted)
            {
                if (e.X < (Width - playerPb.Width))
                {
                    playerPb.Left = e.X;
                    ball.Left = playerPb.Left + (playerPb.Width / 2) - (ball.Width / 2);
                }
            }
            // Manejo de movimiento de barra cuando el juego ya inicio
            else
            {
                if (e.X < (Width - playerPb.Width))
                    playerPb.Left = e.X;
            }
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            if (!GameData.gameStarted)
                return;

            try
            {
                BallMovements?.Invoke();
            }
            catch(OutOfBoundsException ex)
            {
                try
                {
                    GameData.lifes--;
                    GameData.gameStarted = false;
                    timer1.Stop();

                    RepositionElements();
                    UpdateElements();

                    if (GameData.lifes == 0)
                    {
                        throw new NoRemainingLifesException("");
                    }
                }
                catch (NoRemainingLifesException ex2)
                {
                    timer1.Stop();
                    FinishGame?.Invoke();
                }
            }
        }

        // Detectar Space para iniciar el juego
        private void ControlArkanoid_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (!GameData.gameStarted)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Space:
                            GameData.gameStarted = true;
                            timer1.Start();
                            break;
                        default:
                            throw new WrongKeyPressedException("Presione Space para iniciar el juego");
                    }
                }
            }
            catch(WrongKeyPressedException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Rutina de rebote de pelota
        private void BounceBall()
        {
            // Rebote en la parte superior
            if (ball.Top < scorePanel.Height)
            {
                GameData._y = -GameData._y;
                return;
            }

            // Pelota se sale de los bounds
            if (ball.Bottom > Height)
                throw new OutOfBoundsException("");

            // Rebote en lado derecho o izquierdo de la ventana
            if (ball.Left < 0 || ball.Right > Width)
            {
                GameData._x = -GameData._x;
                return;
            }

            // Rebote con el jugador
            if (ball.Bounds.IntersectsWith(playerPb.Bounds))
            {
                GameData._y = -GameData._y;
                return;
            }

            // Rutina de colisiones con cpb
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (cpb[i, j] != null && ball.Bounds.IntersectsWith(cpb[i, j].Bounds))
                    {   
                        GameData.score += (int)(cpb[i, j].Hits * GameData.ticksCount);
                        cpb[i, j].Hits--;

                        if (cpb[i, j].Hits == 0)
                        {
                            Controls.Remove(cpb[i, j]);
                            cpb[i, j] = null;

                            remainingPb--;
                        }
                        else if(cpb[i, j].Tag.Equals("blinded"))
                            cpb[i, j].BackgroundImage = Image.FromFile("../../Img/tb2.png");

                        GameData._y = -GameData._y;

                        score.Text = GameData.score.ToString();

                        if (remainingPb == 0)
                            WinningGame?.Invoke();

                        return;
                    }
                }
            }
        }

        private void MoveBall()
        {
            ball.Left += GameData._x;
            ball.Top += GameData._y;
        }

        // Se encarga de inicializar todos los elementos del panel de puntajes + vidas
        private void ScoresPanel()
        {
            // Instanciar panel
            scorePanel = new Panel();

            // Setear elementos del panel
            scorePanel.Width = Width;
            scorePanel.Height = (int)(Height * 0.07);

            scorePanel.Top = scorePanel.Left = 0;

            scorePanel.BackColor = Color.Black;

            #region Label + PictureBox
            // Instanciar pb
            heart = new PictureBox();

            heart.Height = heart.Width = scorePanel.Height;

            heart.Top = 0;
            heart.Left = 20;

            heart.BackgroundImage = Image.FromFile("../../Img/Heart.png");
            heart.BackgroundImageLayout = ImageLayout.Stretch;
            #endregion

            #region N cantidad de PictureBox
            hearts = new PictureBox[GameData.lifes];

            for(int i = 0; i < GameData.lifes; i++)
            {
                // Instanciacion de pb
                hearts[i] = new PictureBox();

                hearts[i].Height = hearts[i].Width = scorePanel.Height;

                hearts[i].BackgroundImage = Image.FromFile("../../Img/Heart.png");
                hearts[i].BackgroundImageLayout = ImageLayout.Stretch;

                hearts[i].Top = 0;

                if (i == 0)
                    // corazones[i].Left = 20;
                    hearts[i].Left = scorePanel.Width / 2;
                else
                {
                    hearts[i].Left = hearts[i - 1].Right + 5;
                }
            }
            #endregion

            // Instanciar labels
            remainingLifes = new Label();
            score = new Label();

            // Setear elementos de los labels
            remainingLifes.ForeColor = score.ForeColor = Color.White;

            remainingLifes.Text = "x " + GameData.lifes.ToString();
            score.Text = GameData.score.ToString();

            remainingLifes.Font = score.Font = new Font("Microsoft YaHei", 24F);
            remainingLifes.TextAlign = score.TextAlign = ContentAlignment.MiddleCenter;

            remainingLifes.Left = heart.Right + 5;
            score.Left = Width - 100;

            remainingLifes.Height = score.Height = scorePanel.Height;

            scorePanel.Controls.Add(heart);
            scorePanel.Controls.Add(remainingLifes);
            scorePanel.Controls.Add(score);

            foreach(var pb in hearts)
            {
                scorePanel.Controls.Add(pb);
            }

            Controls.Add(scorePanel);
        }

        // Reposicionamiento de elementos luego de perder una vida

        private void RepositionElements()
        {
            playerPb.Left = (Width / 2) - (playerPb.Width / 2);
            ball.Top = playerPb.Top - ball.Height;
            ball.Left = playerPb.Left + (playerPb.Width / 2) - (ball.Width / 2);
        }

        // Actualizacion de elementos luego de perder una vida
        private void UpdateElements()
        {
            remainingLifes.Text = "x " + GameData.lifes.ToString();

            scorePanel.Controls.Remove(hearts[GameData.lifes]);
            hearts[GameData.lifes] = null;
        }
    }
}
