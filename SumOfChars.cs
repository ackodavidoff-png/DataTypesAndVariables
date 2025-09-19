namespace SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char CurrentCharecter = char.Parse(Console.ReadLine());
                sum += (int)CurrentCharecter;
            }
            //The sum equals: 399
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
