internal class Program
{
    private static void Main(string[] args)
    {
        var digi = DigitizeLinq(35231);

        foreach (var item in digi)
        {
            Console.WriteLine(item);
        }
    }

    public static long[] Digitize(long n)
    {
        var result = new List<long>();
        var longToString = n.ToString();
        var reverseLongString = longToString.Reverse();

        foreach (var i in reverseLongString)
        {
            result.Add((long)char.GetNumericValue(i));
        }

        return result.ToArray();
    }

    public static long[] DigitizeLinq(long n) =>n.ToString()
                .Reverse()
                .Select(x => (long)char.GetNumericValue(x))
                .ToArray();


}