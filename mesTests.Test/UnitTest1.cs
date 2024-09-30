namespace mesTests.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        bool test = true;

        Assert.True(test);
    }
    [Fact]
    public void Test2()
    {
        bool test = false;

        Assert.True(test);
    }
}