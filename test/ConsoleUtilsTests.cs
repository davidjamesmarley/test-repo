namespace Test;

public class ConsoleUtilsTests
{
    [Fact]
    public void ConsoleUtils_GetAppVersion_ReturnVersionString()
    {
        string result = Lib.ConsoleUtils.GetBaseDirectory();

        Assert.NotNull(result);
        Assert.True(result.Length > 0);
    }
}