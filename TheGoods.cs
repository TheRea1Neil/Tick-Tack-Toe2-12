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
        public string PutInPlace(//parameter will be the )
        {
            //take list object
            List<object> BoardArray = new List<object>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };


            //
        }

        public string PrintBoard(List<object> boardArray)
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

            return boardString;
        }

        public string WeDaBest(BoardArray)
        {


            return //winner
        }

    }
}
