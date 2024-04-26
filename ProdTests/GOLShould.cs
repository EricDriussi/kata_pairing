using FizzBuzz.GOL;
using Xunit;

namespace FizzBuzzTests;

public class GOLShould
{
    [Fact]
    public void GetACellIfAlive()
    {
        var board = new Board(10, 10);
        board.SetCell(5, 5, new Cell(true));

        Assert.True(board.GetCell(5, 5).IsAlive());
    }

    [Fact]
    public void GetACellIfDead()
    {
        var board = new Board(10, 10);
        board.SetCell(5, 5, new Cell(false));

        Assert.False(board.GetCell(5, 5).IsAlive());
    }

    [Fact]
    public void GetNoCell()
    {
        var board = new Board(10, 10);

        Assert.Null(board.GetCell(5, 5));
    }

    [Fact]
    public void NotSetACellOutsideBounds()
    {
        var board = new Board(10, 10);

        Assert.Throws<IndexOutOfRangeException>(() => board.SetCell(11, 11, new Cell(true)));
    }

    [Fact]
    public void NotGetACellOutsideBounds()
    {
        var board = new Board(10, 10);

        Assert.Throws<IndexOutOfRangeException>(() => board.GetCell(11, 11));
    }

    [Fact]
    public void AnyLiveCellWithFewerThanTwoLiveNeighboursDies()
    {
        var board = new Board(10, 10);
        var game= new Game(board);
        board.SetCell(5, 5, new Cell(true));

        game.NextGen();

        Assert.False(board.GetCell(5, 5).IsAlive());
    }

    [Fact]
    public void AnyLiveCellWithTwoOrMoreLiveNeighboursLives()
    {
        var board = new Board(3, 3);
        var game= new Game(board);
        var cellToTest = new Cell(true);

        board.SetCell(0, 1, new Cell(true));
        board.SetCell(1, 1, cellToTest);
        board.SetCell(2, 1, new Cell(true));

        game.NextGen();

        Assert.True(cellToTest.IsAlive());
    }


}

