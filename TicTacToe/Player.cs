namespace TicTacToe;

public class Player
{
    public Cell Cell { get; }

    public Player(Cell cell)
    {
        Cell = cell;
    }

    public Square MakeChoice(Board board)
    {
        while (true)
        {
            Console.Write("What square do you want to play in?: ");
            int input = int.Parse(Console.ReadLine());

            Square choice = input switch
            {
                1 => new Square(0, 0),
                2 => new Square(0, 1),
                3 => new Square(0, 2),
                4 => new Square(1, 0),
                5 => new Square(1, 1),
                6 => new Square(1, 2),
                7 => new Square(2, 0),
                8 => new Square(2, 1),
                9 => new Square(2, 2),
            };

            if (board.IsEmpty(choice.Row, choice.Column))
            {
                return choice;
            }
            else
            {
                Console.WriteLine("This cell is already used!");
            }
        }
    }
}