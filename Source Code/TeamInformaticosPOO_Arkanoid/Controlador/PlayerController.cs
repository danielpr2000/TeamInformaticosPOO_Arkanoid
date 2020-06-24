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
            var dt = ConnectionDB.ExecuteQuery($"SELECT * FROM PLAYER WHERE nickname = '{nickname}'");

            if(dt.Rows.Count > 0)
                return true;
            else
            {
                ConnectionDB.ExecuteNonQuery("INSERT INTO PLAYER(nickname) VALUES" +
                    $"('{nickname}')");

                return false;
            }
        }

        public static void CreateNewScore(int idPlayer, int score)
        {
            ConnectionDB.ExecuteNonQuery("INSERT INTO SCORE(idPlayer, score) VALUES" +
                $"({idPlayer}, {score})");
        }

        public static List<Player> ObtainTopPlayers()
        {
            var topPlayers = new List<Player>();
            DataTable dt = ConnectionDB.ExecuteQuery("SELECT pl.nickname, sc.idscore " +
                                                    "FROM PLAYER pl, SCORES sc " +
                                                    "WHERE pl.idPlayer = sc.idPlayer " +
                                                    "ORDER BY sc.idscore DESC " +
                                                    "LIMIT 10");

            foreach(DataRow dr in dt.Rows)
            {
                topPlayers.Add(new Player(dr[0].ToString(), Convert.ToInt32(dr[1])));
            }

            return topPlayers;
        }
    }
}
