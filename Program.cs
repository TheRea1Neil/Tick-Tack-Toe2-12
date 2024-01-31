using Tick_Tack_Toe2_12;


class Program
{
    static void Main(string[] args)
    {
       // using support;


        string player = "X"; //initiate the player variable to stoe either X or O
        bool turn = true; //this alternes from ture to false each turn to change the value of player from X to O and vis versa
        bool winner = false; // holds the state if someone has one the game or not the game will contiue as long as this is false
        int userInput = 10; //this is where the user input is saved. it is initialed to 10 bc it is a number greater than 9 and will give an error if left as is
        
        //initate the object list that holds the numbers 1-9 that will be converted to X or O as the game progresses
            List<object> BoardArray = new List<object>
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9
        };

        // Change the value at position 5 to "X"
        // BoardArray[4] = "X";


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //main sequence


        //welcom to game
        Console.WriteLine("Welcom to the Tic-Tac-Toe game!");
        
        do
        {
            TheGoods.PrintBoard(BoardArray);
            
           
            //deterimin the turn and player
            if (turn == true)
            {
                player = "X";
            }
            else
            {
                player = "O";
            }

            Console.WriteLine($"It is player {player}'s turn:");

            do
            {
                //check if the input is a valid number between 1 and 9
                do
                {
                    Console.Write("Enter an integer between 1 and 9: ");

                } while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 9);

               // make sure the space has not been taken by checking if it is a string. if it already is a sting let the player input again
            } while (BoardArray[userInput - 1] is string);

            //update the board postion with the player
            BoardArray[userInput - 1] = player;

           
           


            //invert the value of turn
            turn = !turn;

        } while (!winner);
       










    }
}