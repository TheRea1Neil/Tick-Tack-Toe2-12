using Tick_Tack_Toe2_12;

TheGoods theGoods = new TheGoods();

List<object> BoardArray = new List<object>
{
    1,2,3,4,5,6,7,8,9
};

theGoods.Organize(BoardArray, 4, "O");
theGoods.Organize(BoardArray, 5, "X");
theGoods.Organize(BoardArray, 6, "O");
theGoods.Organize(BoardArray, 1, "X");
theGoods.Organize(BoardArray, 2, "O");
theGoods.Organize(BoardArray, 3, "O");
theGoods.Organize(BoardArray, 7, "O");
theGoods.Organize(BoardArray, 8, "X");
theGoods.Organize(BoardArray, 9, "O");

theGoods.PrintBoard(BoardArray);

string winner = theGoods.WeDaBest(BoardArray);

Console.WriteLine(winner);

