namespace Test;

public class ProgramTests
{
    [Fact]
    public void MainWithEmptyArgsArrayShouldReturnOne()
    {
        string[] args = new string[] { };
        int ec = App.Program.Main(args);

        Assert.Equal(1, ec);
    }

    [Fact]
    public void MainWithValidVersionArgsArrayShouldReturnZero()
    {
        string[] args = new string[] { "--version" };
        int ec = App.Program.Main(args);

        Assert.Equal(0, ec);
    }

    [Fact]
    public void MainWithValidNameArgsArrayShouldReturnZero()
    {
        string[] args = new string[] { "--name", "David" };
        int ec = App.Program.Main(args);

        Assert.Equal(0, ec);
    }
}
