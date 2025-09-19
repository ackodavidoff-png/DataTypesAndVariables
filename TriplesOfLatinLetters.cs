namespace TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char FirstChar = (char)('a' + i);
                for (int j = 0; j < n; j++)
                {
                    char SecondChar = (char)('a' + j);
                    for (int k = 0; k < n; k++)
                    {
                        char ThirdChar = (char)('a' + k);
                        Console.WriteLine($"{FirstChar}{SecondChar}{ThirdChar}");
                    }
                }
            }
        }
    }
}
