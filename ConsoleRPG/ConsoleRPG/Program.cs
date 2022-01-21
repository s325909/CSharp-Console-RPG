using System;

namespace ConsoleRPG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Console RPG!");

            Game game = new();
            game.run();
        }
    }
}
