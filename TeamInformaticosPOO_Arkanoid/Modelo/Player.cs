using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Modelo
{
    public class Player
    {
        public int idPlayer { get; set; }
        public string Nickname { get; set; }
        public int Score { get; set; }

        public Player(string nickname, int score)
        {
            Nickname = nickname;
            Score = score;
        }
    }
}
