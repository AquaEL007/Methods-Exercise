using System.Diagnostics.CodeAnalysis;

namespace _05.AddandSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());

            int result = SumOfFirstTwo(one, two, three);

            Console.WriteLine(result);
        }

        static int SumOfFirstTwo(int one, int two, int three)
        {
            int sumOfFirstTwo = one + two;
            return sumOfFirstTwo - three;
        }
    }
}