namespace FizzBuzz.GOL;
// Any live cell with fewer than two live neighbours dies, as if caused by under-population.
// Any live cell with two or three live neighbours lives on to the next generation.
// Any live cell with more than three live neighbours dies, as if by overcrowding.
// Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

public class Board
{
    private readonly Cell[,] board;

    public Board(int x, int y)
    {
        board = new Cell[x, y];
    }

    public void SetCell(int x, int y, Cell cell)
    {
        board[x, y] = cell;
    }

    public Cell GetCell(int x, int y)
    {
        return board[x, y];
    }

    public int GetWidth()
    {
        return board.GetLength(0);
    }

    public int GetHeight()
    {
        return board.GetLength(1);
    }
}

public class Cell
{
    private bool alive;

    public Cell(bool alive)
    {
        this.alive = alive;
    }

    public bool IsAlive()
    {
        return alive;
    }

    public void Died()
    {
        this.alive = false;
    }
}
