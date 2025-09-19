namespace DataTypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int aPLUSb = a + b;
            int aPLUSbDIVIDEDBYc = aPLUSb / c;
            int aPLUSbDIVIDEDBYcMULTIPLIEDBYd = aPLUSbDIVIDEDBYc * d;
            Console.WriteLine(aPLUSbDIVIDEDBYcMULTIPLIEDBYd);
        }
    }
}
