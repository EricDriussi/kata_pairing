namespace FizzBuzz.GOL;

public class Game
{
    private readonly Board board;

    public Game(Board board)
    {
        this.board = board;
    }

    public void NextGen()
    {
        for (int x = 0; x < board.GetWidth(); x++)
        {
            for (int y = 0; y < board.GetHeight(); y++)
            {
                var cell = board.GetCell(x, y);
                if (cell!=null && cell.IsAlive())
                {
                    if(HasLessThanTwoLiveNeighbours(x, y))
                    {
                        cell.Died();
                    }
                }
            }
        }
    }

    private bool HasLessThanTwoLiveNeighbours(int x, int y)
    {
        //Verificar si tiene menos de dos vecinos vivos
        //Tengo que comprobar si hay vecinos vivos en las 8 direcciones
        //Si hay menos de dos vecinos vivos, la celda muere

        int liveNeighbours = 0;

        var hasNeighboursAtSouthWest = x > 0 && y > 0 && board.GetCell(x - 1, y - 1)!=null && board.GetCell(x - 1, y - 1).IsAlive();
        if (hasNeighboursAtSouthWest)
        {
            liveNeighbours++;
        }

        var hasNeighboursAtSouth = y > 0 && board.GetCell(x, y - 1)!=null && board.GetCell(x, y - 1).IsAlive();
        if (hasNeighboursAtSouth)
        {
            liveNeighbours++;
        }

        var hasNeighboursAtSouthEast = x < board.GetWidth() - 1 && y > 0 && board.GetCell(x + 1, y - 1)!=null && board.GetCell(x + 1, y - 1).IsAlive();
        if (hasNeighboursAtSouthEast)
        {
            liveNeighbours++;
        }

        var hasNeighboursAtWest = x > 0 && board.GetCell(x - 1, y)!=null && board.GetCell(x - 1, y).IsAlive();
        if (hasNeighboursAtWest)
        {
            liveNeighbours++;
        }

        var hasNeighboursAtEast = x < board.GetWidth() - 1 &&  board.GetCell(x + 1, y)!=null &&  board.GetCell(x + 1, y).IsAlive();
        if (hasNeighboursAtEast)
        {
            liveNeighbours++;
        }

        var hasNeighboursAtNorthWest = x > 0 && y < board.GetHeight() - 1 && board.GetCell(x - 1, y + 1)!=null && board.GetCell(x - 1, y + 1).IsAlive();
        if (hasNeighboursAtNorthWest)
        {
            liveNeighbours++;
        }

        var hasNeighboursAtNorth = y < board.GetHeight() - 1 && board.GetCell(x, y + 1)!=null && board.GetCell(x, y + 1).IsAlive();
        if (hasNeighboursAtNorth)
        {
            liveNeighbours++;
        }

        var hasVecinosAtNorthEast = x < board.GetWidth() - 1 && y < board.GetHeight() - 1 && board.GetCell(x + 1, y + 1)!=null && board.GetCell(x + 1, y + 1).IsAlive();
        if (hasVecinosAtNorthEast)
        {
            liveNeighbours++;
        }

        return liveNeighbours < 2;
    }
}