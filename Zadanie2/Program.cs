class Program
{
    static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0) return 0;

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return (double) sum / numbers.Length;
    } 

    static void Main() {
        int[] nums = { 5, 10, 15, 20, 25 };
        double average = CalculateAverage(nums);
        Console.WriteLine("Average: " + average);
    }
}