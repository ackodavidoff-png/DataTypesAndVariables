using System.Collections.Generic;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	On the first line, you will receive n – an integer.
            //•	On the second line, you will receive m – an integer.
            //•	On the third line, you will receive y – an integer.
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int targets = 0;
            double percent = n * (double)0.5;
            while(n >= m)
            {
                n -= m;
                targets++;
                if (percent == n && y != 0)
                {
                    n /= y;
                }
            }   
            Console.WriteLine(n);
            Console.WriteLine(targets);
        }
    }
}
