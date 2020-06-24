using Arkanoid.Modelo;
using System;
using System.Collections.Generic;
using System.Data;

namespace Arkanoid.Controlador
{
    public static class PlayerController
    {
        public static bool CreatePlayer(string nickname)
        {
            var dt = DataBaseController.ExecuteQuery($"SELECT * FROM PLAYER WHERE nickname = '{nickname}'");

            if(dt.Rows.Count > 0)
                return true;
            else
            {
                DataBaseController.ExecuteNonQuery("INSERT INTO PLAYER(nickname) VALUES" +
                    $"('{nickname}')");

                return false;
            }
        }

        public static void CreateNewScore(int idPlayer, int score)
        {
            DataBaseController.ExecuteNonQuery("INSERT INTO SCORE(idPlayer, score) VALUES" +
                $"({idPlayer}, {score})");
        }

        public static List<Player> ObtainTopPlayers()
        {
            var topPlayers = new List<Player>();
            DataTable dt = DataBaseController.ExecuteQuery("SELECT pl.nickname, sc.score " +
                                                    "FROM PLAYER pl, SCORES sc " +
                                                    "WHERE pl.idPlayer = sc.idPlayer " +
                                                    "ORDER BY sc.score DESC " +
                                                    "LIMIT 10");

            foreach(DataRow dr in dt.Rows)
            {
                topPlayers.Add(new Player(dr[0].ToString(), Convert.ToInt32(dr[1])));
            }

            return topPlayers;
        }
    }
}
