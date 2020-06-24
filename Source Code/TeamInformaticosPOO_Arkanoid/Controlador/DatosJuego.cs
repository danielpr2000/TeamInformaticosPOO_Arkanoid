namespace Arkanoid.Controlador
{
    public static class GameData
    {
        // Variables necesarias para la funcionalidad del juego
        public static bool gameStarted;
        public static double ticksCount;
        public static int _x = 10, _y = -_x, lifes, score;
        
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
