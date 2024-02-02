using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Tick_Tack_Toe2_12
{
    public class TheGoods
    {
        //Print the board based on info passed to it
        public List<object> Organize(List<object> BoardArray, int userInput, string playerSymbol) //Require the boardArray, userInput, and playersymbol
        {
            //safe guard to ensure user input is between 1 and 9
            if (userInput < 1 || userInput > 9)
            {
                Console.WriteLine("User Input is not on the tic tac toe chart, please choose number betwween 1 and 9");
                Environment.Exit(1);
            }

            //update the board position with the player symbol
            BoardArray[userInput - 1] = playerSymbol;

            return BoardArray;

        }

        public static void PrintBoard(List<object> boardArray)
        {
            string boardString = "";

            for (int i = 0; i < boardArray.Count; i++)
            {
                boardString += boardArray[i] + " ";

                // After every third element, append a newline character to start a new row
                if ((i + 1) % 3 == 0)
                {
                    boardString += "\n";
                }
            }

            Console.WriteLine(boardString);
        }

        //Returns winner symbol or if the game was a tie
         public static string WeDaBest(List<object> BoardArray)
        {
            string winner = "";

            //All possible winning combos
            List<int[]> winningCombos = new List<int[]>
            {
                new int[] {0, 1, 2},//rows
                new int[] {3, 4, 5},
                new int[] {6, 7, 8},
                new int[] {0, 3, 6},//columns
                new int[] {1, 4, 7},
                new int[] {2, 5, 8},
                new int[] {0, 4, 8},//diagonals
                new int[] {2, 4, 6},
            };

            //checks for winning combos in the BoardArray
            foreach (var combo in winningCombos)
            {
                object a = BoardArray[combo[0]];
                object b = BoardArray[combo[1]];
                object c = BoardArray[combo[2]];

                //if it's not a number and they are the same symbol declare winner
                if (!(a is int) && a.Equals(b) && a.Equals(c))
                {
                    winner = ($" Player {a.ToString()} wins!");
                }
            }

            //check if there are any ints in the list to see if the game is over/ a tie
            bool containsIntegers = BoardArray.OfType<int>().Any();

            //if there was no winner declared, the game was a tie
            if (containsIntegers == false)
            {
                winner = ("The game was a tie!");
            }

            return winner;
        }

    }
}
