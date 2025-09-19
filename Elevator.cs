namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)NumberOfPeople / capacity);
            Console.WriteLine(courses);
        }
    }
}
