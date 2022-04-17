// Brian Potter
// CST-150
// 04/10/2022
// Primary souce used for project understanding is assigned textbook
// Majority of logic used was brute force and can likely be cleaned up at a later date
// The code is of my own work

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity13
{
    public partial class Activity13 : Form
    {
        public Activity13()
        {
            InitializeComponent();
        }        

        private void newGameButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[,] ticTacToeBoard = new int[3,3];
            int winner = -1;

            // Initialize Board to -1 for all squares
            for (int row = 0; row < ticTacToeBoard.GetLength(0); row++)
            {
                for (int col = 0; col < ticTacToeBoard.GetLength(1); col++)
                {
                    ticTacToeBoard[row, col] = -1;
                }

            }

            // Start filling in squares with random # between 0 & 1
            // Check for a winner after each square filled
            // Once a winner is determined the rest of the board remains unfilled
            for (int row = 0; row < ticTacToeBoard.GetLength(0) && winner == -1; row++)
            {
                for (int col = 0; col < ticTacToeBoard.GetLength(1) && winner == -1; col++)
                {
                    ticTacToeBoard[row, col] = rand.Next(2);
                    winner = declareWinner(ticTacToeBoard);
                }                
            }

            // Display final board using standard Xs & Os
            displayBoard(ticTacToeBoard);
           
            // Populate winner in result label
            if (winner == 0)
                resultLabel.Text = "O Wins!";
            else if (winner == 1)
                resultLabel.Text = "X Wins!";
            else
                resultLabel.Text = "Tie Game!";
        }

        private int declareWinner(int [,] board)
        {
            int winningValue = -1;

            // First if checks to make sure a random number has been assigned to entire row or column
            // Second if checks for a winning combination 

            // Check for a horizontal win
            if (board[0,1] != -1)
            {
                if (board[0, 0] == board[0, 1] &&
                    board[0, 1] == board[0, 2])
                {
                    winningValue = board[0, 0];
                }
            }

            if (board[1,1] != -1)
            {
                if (board[1, 0] == board[1, 1] &&
                    board[1, 1] == board[1, 2])
                {
                    winningValue = board[1, 0];
                }
            }

            if (board[2,1] != -1)
            {
                if (board[2, 0] == board[2, 1] &&
                    board[2, 1] == board[2, 2])
                {
                    winningValue = board[2, 0];
                }
            }
            
            // Check for a vertical win
            if (board[1,0] != -1)
            {
                if (board[0, 0] == board[1, 0] &&
                    board[1, 0] == board[2, 0])
                {
                    winningValue = board[0, 0];
                }
            }

            if (board[1,1] != -1)
            {
                if (board[0, 1] == board[1, 1] &&
                    board[1, 1] == board[2, 1])
                {
                    winningValue = board[0, 1];
                }
            }

            if (board[1,2] != -1)
            {
                if (board[0, 2] == board[1, 2] &&
                    board[1, 2] == board[2, 2])
                {
                    winningValue = board[0, 2];
                }
            }

            // Check for diagional win
            // No need to check for non-filled in boxes since all boxes will be filled in at this point
            if (board[0, 0] == board[1, 1] &&
                board[1, 1] == board[2, 2])
                {
                    winningValue = board[0, 0];
                }

            if (board[0, 2] == board[1, 1] &&
                    board[1, 1] == board[2, 0])
                {
                    winningValue = board[0, 2];
                }

            return winningValue;            
        }

        private void displayBoard(int[,] board)
        {
            // Convert box with a value of "0" to "O" or
            // Convert box with a value of "1" to "X" or
            // Convert box to blank
            if (board[0, 0] == 0)
                C1R1_label.Text = "O";
            else if (board[0, 0] == 1)
                C1R1_label.Text = "X";
            else
                C1R1_label.Text = "   ";

            if (board[0, 1] == 0)
                C1R2_label.Text = "O";
            else if (board[0, 1] == 1)
                C1R2_label.Text = "X";
            else
                C1R2_label.Text = "   ";

            if (board[0, 2] == 0)
                C1R3_label.Text = "O";
            else if (board[0, 2] == 1)
                C1R3_label.Text = "X";
            else
                C1R3_label.Text = "   ";

            if (board[1, 0] == 0)
                C2R1_label.Text = "O";
            else if (board[1,0] == 1)
                C2R1_label.Text = "X";
            else
                C2R1_label.Text = "   ";

            if (board[1, 1] == 0)
                C2R2_label.Text = "O";
            else if (board[1, 1] == 1)
                C2R2_label.Text = "X";
            else
                C2R2_label.Text = "   ";

            if (board[1, 2] == 0)
                C2R3_label.Text = "O";
            else if (board[1, 2] == 1)
                C2R3_label.Text = "X";
            else
                C2R3_label.Text = "   ";

            if (board[2, 0] == 0)
                C3R1_label.Text = "O";
            else if (board[2, 0] == 1)
                C3R1_label.Text = "X";
            else
                C3R1_label.Text = "   ";

            if (board[2, 1] == 0)
                C3R2_label.Text = "O";
            else if (board[2, 1] == 1)
                C3R2_label.Text = "X";
            else
                C3R2_label.Text = "   ";

            if (board[2, 2] == 0)
                C3R3_label.Text = "O";
            else if (board[2, 2] == 1)
                C3R3_label.Text = "X";
            else
                C3R3_label.Text = "   ";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
