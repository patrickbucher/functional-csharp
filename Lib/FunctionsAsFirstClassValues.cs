namespace Lib;

public class FunctionsAsFirstClassValues
{
    public static IEnumerable<int> ArithmeticPipeline(IEnumerable<int> numbers)
    {
        var increment = (int x) => x + 1;
        var decrement = (int x) => x - 1;
        var twice = (int x) => x * 2;
        return numbers.Select(increment).Select(twice).Select(decrement);
    }
}
