namespace BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int KegsCount = int.Parse(Console.ReadLine());
            string BiggestKegModel = "";
            double BiggestKeg = 0;
            for (int i = 0; i < KegsCount; i++)
            {
                string KegName = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                double v = Math.PI * Math.Pow(r, 2) * h;
                if (BiggestKeg < v)
                {
                    BiggestKeg = v;
                    BiggestKegModel = KegName;
                }
            }
            Console.WriteLine(BiggestKegModel);
        }
    }
}
