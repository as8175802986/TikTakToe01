using System;

namespace TikTakGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tik Tak Toe");
            TikTakToe game = new TikTakToe();
            game.Display();
            game.InputLetter();
            
        }
    }
}
