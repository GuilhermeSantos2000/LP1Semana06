using System;
using System.Globalization;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int NumberOfEnemies = int.Parse(args[0]);
            Enemy[] enemies = new Enemy[NumberOfEnemies];

            for (int i = 0; i < NumberOfEnemies; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string enemyName = Console.ReadLine();
                enemies[i] = new Enemy(enemyName);
            }

            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}");
                Console.WriteLine($"{Enemy.GetPowerUpCount()}");
            }
        }
    }
}
