using System;

namespace ConsoleRPG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Console RPG, your adventure starts here!");

            Game game = new();
            game.run();

            // Characters.Character character = new();
        }
    }
}
