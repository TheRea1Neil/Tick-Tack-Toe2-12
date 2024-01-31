using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Tick_Tack_Toe2_12
{
    internal class TheGoods
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

    }
}
