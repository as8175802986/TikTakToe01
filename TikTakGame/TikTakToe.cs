using System;
using System.Collections.Generic;
using System.Text;

namespace TikTakGame
{
    class TikTakToe
    {
        char[] board = { ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
        char player, computer;
        public void InputLetter()
        {
            Console.WriteLine("letter");
            char letter = Convert.ToChar(Console.ReadLine());
            if (letter == 'X')
            {
                player = 'X';
                computer = 'O';

            }
            else
            {
                player = 'O';
                computer = 'X';
            }
            Console.WriteLine("Input player {0} and computer {1}", player, computer);
        }
        public void Display()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |   {2}  ", board[1], board[2], board[3]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |   {2}  ", board[4], board[5], board[6]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |   {2}  ", board[7], board[8], board[9]);
            Console.WriteLine("     |     |     ");

        }
    }
}
