namespace Test;

using Lib;

public class FunctionsAsFirstClassValuesTest
{
    [Fact]
    public void TestArithmeticPipeline()
    {
        var numbers = Enumerable.Range(1, 3);
        var expected = new List<int>() { 3, 5, 7 };
        var actual = FunctionsAsFirstClassValues.ArithmeticPipeline(numbers);
        Assert.Equal(expected, actual);
    }
}
