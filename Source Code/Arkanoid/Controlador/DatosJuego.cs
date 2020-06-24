namespace Arkanoid
{
    public static class GameData
    {
        // Variables necesarias para la funcionalidad del juego
        public static bool gameStarted = false;
        public static double ticksCount = 0;
        public static int dirX = 10, dirY = -dirX, lifes = 3, score = 0;
        
        // Inicializacion de variables
        public static void InitializeGame()
        {
            gameStarted = false;
            ticksCount = 0;
            lifes = 3;
            score = 0;
        }
    }
}
