using System;
using System.Collections.Generic;
using System.Data;

namespace Arkanoid
{
    public static class PlayerData
    {
        public static bool CreatePlayer(string nickname)
        {
            var dt = ConnectionDB.ExecuteQuery($"SELECT * FROM PLAYER WHERE nickname = '{nickname}'");

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                ConnectionDB.ExecuteNonQuery("INSERT INTO PLAYER(nickname) VALUES ('{nickname}')");

                return false;
            }
        }

        public static void NewScore(int idPlayer, int sc)
        {
            ConnectionDB.ExecuteNonQuery($"INSERT INTO  SCORE(IdPlayer, score) VALUES ({idPlayer},{sc})");
        }//++++++

        public static List<Player> PlayersTop()
        {
            var topPlayers = new List<Player>();
            var dt = ConnectionDB.ExecuteQuery("SELECT pl.nickname, sc score FROM PLAYER pl, SCORES sc" +
                                               "WHERE pl.IdPlayer = sc.IdPlayer ORDER BY sc.score DESC LIMIT 10");

            foreach (DataRow dr  in dt.Rows)
            {
                topPlayers.Add(new Player(dr[0].ToString(),Convert.ToInt32(dr[1])));
            }
            
            return topPlayers;
        }
    }
}