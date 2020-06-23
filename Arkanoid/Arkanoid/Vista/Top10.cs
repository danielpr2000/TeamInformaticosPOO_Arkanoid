using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    
    public partial class Top10 : UserControl
    {
        private Label[][] players;
        public Top10()
        {
            InitializeComponent();
        }

        private void Top10_Load(object sender, EventArgs e)
        {
            //Players();

            }

        private void Players()
        {
            var playerList = PlayerData.PlayersTop();
            players = new Label[10][];

            int sampleTop = lbl1.Bottom + 50 , sampleLeft = 20;
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    players[i][j] = new Label();

                    if (j == 0)
                    {
                        players[i][j].Text = playerList[i].Nickname;
                        players[i][j].Left = sampleLeft;
                    }
                    else
                    {
                        players[i][j].Text = playerList[i].Score.ToString();
                        players[i][j].Left = Width / 2 + sampleLeft;
                    }

                    players[i][j].Top = sampleTop + (sampleTop) * i;

                    players[i][j].Font = new Font("Century", 36f);
                    players[i][j].TextAlign = ContentAlignment.MiddleCenter;
                    
                    Controls.Add(players[i][j]);
                } 
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Top10 top10 = new Top10();
            FormMenu menu = new FormMenu();
            top10.Hide();
           menu.Show();
        }
    }
    }
