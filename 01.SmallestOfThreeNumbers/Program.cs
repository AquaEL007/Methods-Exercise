namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int[] numbers = { numberOne, numberTwo, numberThree };
            SmallestNumberPrint(numbers);

        }

        private static void SmallestNumberPrint(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int smallestNumber = numbers[i];
                if (numbers[0] < numbers[1] && numbers[0] < numbers[2])
                {
                    smallestNumber = numbers[0];
                }
                if (numbers[1] < numbers[0] && numbers[1] < numbers[2])
                {
                    smallestNumber = numbers[1];
                }
                if (numbers[2] < numbers[0] && numbers[2] < numbers[1])
                {
                    smallestNumber = numbers[2];
                }
                if (i == numbers.Length - 1)
                {
                    Console.WriteLine(smallestNumber);
                }
            }
        }
    }
}