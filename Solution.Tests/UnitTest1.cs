namespace Solution.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void Test(int input, bool expected)
    {
        var result = Solution.IsPalindrome(input);

        Assert.Equal(expected, result);
    }
}