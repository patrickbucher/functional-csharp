using System.Linq;

using Lib;

namespace Test;

public class FunctionsAsFirstClassValuesTest
{
    [Fact]
    public void TestArithmeticPipeline()
    {
        var numbers = Enumerable.Range(1, 2, 3);
        var expected = new List<int>() { 3, 5, 7 };
        var actual = FunctionsAsFirstClassValues.ArithmeticPipeline(numbers);
        Assert.Equal(expected, actual);
    }
}
