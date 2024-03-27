namespace TicTacToe;

public class BoardRender
{
    public void Draw(Board board)
    {
        char[,] symbols = new char[3,3];

        symbols[0, 0] = GetCellSymbol(board.GetCellContent(0, 0));
        symbols[0, 1] = GetCellSymbol(board.GetCellContent(0, 1));
        symbols[0, 2] = GetCellSymbol(board.GetCellContent(0, 2));
        
        symbols[1, 0] = GetCellSymbol(board.GetCellContent(1, 0));
        symbols[1, 1] = GetCellSymbol(board.GetCellContent(1, 1));
        symbols[1, 2] = GetCellSymbol(board.GetCellContent(1, 2));
        
        symbols[2, 0] = GetCellSymbol(board.GetCellContent(2, 0));
        symbols[2, 1] = GetCellSymbol(board.GetCellContent(2, 1));
        symbols[2, 2] = GetCellSymbol(board.GetCellContent(2, 2));

        Console.Clear();
        Console.WriteLine($" {symbols[0, 0]} | {symbols[0, 1]} | {symbols[0, 2]}");
        Console.WriteLine($"---+---+---");
        Console.WriteLine($" {symbols[1, 0]} | {symbols[1, 1]} | {symbols[1, 2]}");
        Console.WriteLine($"---+---+---");
        Console.WriteLine($" {symbols[2, 0]} | {symbols[2, 1]} | {symbols[2, 2]}");
    }

    private char GetCellSymbol(Cell cell) => cell switch { Cell.Empty => ' ', Cell.X => 'X', Cell.O => 'O' };
}