namespace Arkanoid.Controlador
{
    public static class DataGame
    {
        public static bool StartGame = false;
        public static double MadeTicks = 0;
        public static int X = 7, Y = -X, lifes=3, scoreGame =0;

        public static void InitializeGame()
        {
            StartGame = false;
            lifes = 3;
            scoreGame = 0;

        }
        
     }
}