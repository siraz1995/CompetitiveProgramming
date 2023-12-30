namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public void result()
    {
        Solution solution = new Solution();

        // Example usage:
        int number = 121;
        bool isPalindrome = solution.IsPalindrome(number);

        Console.WriteLine($"{isPalindrome}");
    }
    public bool IsPalindrome(int x)
    {
        int backup = x;
        int remainder, reverse = 0;

        while (x > 0)
        {
            remainder = x % 10;
            reverse = reverse * 10 + remainder;
            x = x / 10;
        }
        return backup == reverse;
    }

    }
}
