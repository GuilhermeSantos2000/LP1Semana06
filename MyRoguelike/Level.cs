using System;
using Humanizer;
using System.Globalization;

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
            enemiesInRooms = new Enemy[numberOfRooms];
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
            for (int i = 0; i < numberOfRooms; i++)
            {
                if (enemiesInRooms[i] != null)
                {
                    string roomNumberInWords = i.ToOrdinalWords(new CultureInfo("en")).Transform(To.TitleCase);
                    Console.WriteLine($"{roomNumberInWords} room: {enemiesInRooms[i].GetName()}");
                }
            }
        }
        
    }
}
