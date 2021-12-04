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
    }
}
