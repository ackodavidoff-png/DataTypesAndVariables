namespace WaterOverFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Капацитет 255л
            int n = int.Parse(Console.ReadLine());
            int LitersInTank = 0;
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (LitersInTank + liters > byte.MaxValue)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    LitersInTank += liters;
                }
            }
            Console.WriteLine(LitersInTank);
        }
    }
}
