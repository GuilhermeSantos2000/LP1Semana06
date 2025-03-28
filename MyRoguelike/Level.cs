using System;
using Humanizer;

namespace MyRoguelike
{
    public class Level
    {
        private int numberOfRooms;
        private Toughness difficulty;
        private Enemy[] enemiesInRooms;

        public Level(int numberOfRooms, Toughness difficulty)
        {
            this.numberOfRooms = numberOfRooms;
            this.difficulty = difficulty;
        }

        public void SetEnemyInRoom(int roomIndex, Enemy enemy)
        {
            enemiesInRooms[roomIndex] = enemy;
        }

        public int GetNumRooms()
        {
            return numberOfRooms;
        }

        public Toughness GetToughness()
        {
            return difficulty;
        }

        public int GetNumEnemies()
        {
            int numEnemies = 0;
            for (int i = 0; i < numberOfRooms; i++)
            {
                if (enemiesInRooms[i] != null)
                {
                    numEnemies++;
                }
            }
            return numEnemies;
        }

        public void PrintEnemies()
        {
            Console.WriteLine("\nEnemies in the level:");
            for (int i = 0; i < numberOfRooms; i++)
            {
                if (enemiesInRooms[i] != null)
                {
                    string roomNumberInWords = (i + 1).ToWords().Transform(To.TitleCase); // Convert room number to words and capitalize
                    Console.WriteLine($"Room {roomNumberInWords}: {enemiesInRooms[i].GetName()}");
                }
            }
        }
        
    }
}
