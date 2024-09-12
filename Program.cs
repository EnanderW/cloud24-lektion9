namespace lektion9;

class Program
{
    static void Main(string[] args)
    {
        var first = Environment.GetEnvironmentVariable("FIRST");
        var second = Environment.GetEnvironmentVariable("SECOND_FILE");
        Console.WriteLine(first);
        Console.WriteLine(second);

        var secondValue = File.ReadAllText(second);
        Console.WriteLine(secondValue);
    }
}
