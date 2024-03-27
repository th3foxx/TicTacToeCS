namespace TicTacToe;

public class Game
{
    public void Run()
    {
        Board board = new Board();
        BoardRender render = new BoardRender();

        Player player1 = new Player(Cell.X);
        Player player2 = new Player(Cell.O);

        int turns = 0;

        Player currentPlayer = player1;
        
        while (turns < 9)
        {
            render.Draw(board);
            Console.WriteLine($"{currentPlayer.Cell} it's your turn!");
            Square choice = currentPlayer.MakeChoice(board);
            board.FillCell(choice.Row, choice.Column, currentPlayer.Cell);
            if (HasWon(board, Cell.X))
            {
                render.Draw(board);
                Console.WriteLine("X Win!");
                return;
            }
            else if (HasWon(board, Cell.O))
            {
                render.Draw(board);
                Console.WriteLine("O Win!");
                return;
            }
            currentPlayer = currentPlayer == player1 ? player2 : player1;
            turns++;
        }
        
        render.Draw(board);
        Console.WriteLine("Draw!");
    }
    
    private bool HasWon(Board board, Cell value)
    {
        if (board.GetCellContent(0,0) == value && board.GetCellContent(0,1) == value && board.GetCellContent(0,2) == value) return true;
        if (board.GetCellContent(1,0) == value && board.GetCellContent(1,1) == value && board.GetCellContent(1,2) == value) return true;
        if (board.GetCellContent(2,0) == value && board.GetCellContent(2,1) == value && board.GetCellContent(2,2) == value) return true;
        
        if (board.GetCellContent(0,0) == value && board.GetCellContent(1,0) == value && board.GetCellContent(2,0) == value) return true;
        if (board.GetCellContent(0,1) == value && board.GetCellContent(1,1) == value && board.GetCellContent(2,1) == value) return true;
        if (board.GetCellContent(0,2) == value && board.GetCellContent(1,2) == value && board.GetCellContent(2,2) == value) return true;
        
        if (board.GetCellContent(0,0) == value && board.GetCellContent(1,1) == value && board.GetCellContent(2,2) == value) return true;
        if (board.GetCellContent(2,0) == value && board.GetCellContent(1,1) == value && board.GetCellContent(0,2) == value) return true;

        return false;
    }
}