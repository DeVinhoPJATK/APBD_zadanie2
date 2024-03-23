class Program
{
    static int FindMax(int[] numbers) {
        if (numbers == null || numbers.Length == 0) {
            throw new ArgumentException("The array is null or empty.");
        }
        int max = numbers[0];
        
        foreach (int n1 in numbers) {
            if (n1 > max) {
                max = n1;
            }
        }

        return max;
    }

    static void Main() {
        int[] nums = { 5, 10, 3, 99, 8, 15 };
        int max = FindMax(nums);
        Console.WriteLine("Max value: " + max);
    }
}