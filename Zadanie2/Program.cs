class Program
{
    static int FindMaxValue(int[] numbers) {
        if (numbers == null || numbers.Length == 0) {
            throw new ArgumentException("The array is null or empty.");
        }
        int max = numbers[0];
        
        foreach (int num in numbers) {
            if (num > max) {
                max = num;
            }
        }

        return max;
    }

    static void Main() {
        int[] nums = { 5, 10, 3, 99, 8, 15 };
        int max = FindMaxValue(nums);
        Console.WriteLine("Max value: " + max);
    }
}