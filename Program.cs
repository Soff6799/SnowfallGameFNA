using System;

namespace SnowfallGameFNA;

/// <summary>
/// Главная точка входа в приложение.
/// Отвечает за инициализацию и запуск основного игрового цикла SnowfallGame.
/// </summary>
    static internal class Program
    {
        [STAThread]
        private static void Main()
        {
            using (var game = new SnowfallGame())
            {
                game.Run();
            }
        }
    }
