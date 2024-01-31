using Tick_Tack_Toe2_12;

TheGoods theGoods = new TheGoods();

List<object> BoardArray = new List<object>
{
    1,2,3,4,5,6,7,8,9
};

theGoods.Organize(BoardArray, 4, "X");

theGoods.PrintBoard(BoardArray);

