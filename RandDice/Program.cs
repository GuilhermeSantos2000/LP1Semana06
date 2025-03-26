using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            int s = int.Parse(args[1]);

            int sum = 0;

            Random dice = new Random(s);
            for (int i = 0; i < n; i++)
               sum += dice.Next(1,7);

            Console.WriteLine(sum);
        }
    }
}
