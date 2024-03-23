class Program
{
    static void PrintArgument(string arg)
    {
        Console.WriteLine("Argument passed: " + arg);
    }

    static void Main()
    {
        string argument = "Hello, World!";
        PrintArgument(argument);
    }
}