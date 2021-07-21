using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            char[] CreateBoard;
            UC1_InitializeBoard obj = new UC1_InitializeBoard();
            CreateBoard = obj.Board();
            obj.ChoosePlayer();
            obj.ShowBoard(CreateBoard);


        }
    }
}
